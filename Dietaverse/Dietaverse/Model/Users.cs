using Dietaverse.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dietaverse.Model
{
    public class CreateAccountFailException : Exception
    {
        public CreateAccountFailException() { }
        public CreateAccountFailException(string message) : base(message) { }
    }

    public class LoginFailException : Exception
    {
        public LoginFailException() { }
        public LoginFailException(string message) : base(message) { }
    }

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() { }
        public UserNotFoundException(string message) : base(message) { }
    }
    public class Users
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public double weight { get; set; }

        public DateTime joindate { get; set; }

        public db_modelContainer db { get; set; }

        public List<users> usersFromDB { get; set; }

        public Users()
        {
            db = new db_modelContainer();
        }

        public Users(string n, string p, double w, DateTime j)
        {
            name = n;
            password = p;
            weight = w;
            joindate = j;
        }



        public users CreateAccount(string _username, double _weight, string _password)
        {
            using (var db = new db_modelContainer())
            {
                DailySummary summary = new DailySummary { weight = _weight};
                UsersDishesGallery user_dishes = new UsersDishesGallery { };

                var x = db.usersSet;
                foreach (var i in x)
                {
                    if (_username == i.name)
                    {

                        throw new CreateAccountFailException("Username is already occupied!");
                    }
                }

                byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(_password);
                string passwordAsBytes = System.Convert.ToBase64String(toEncodeAsBytes);

                users newuser = new users { name = _username, weight = _weight, password = passwordAsBytes, joindate = DateTime.Now};

                db.usersSet.Add(newuser);
                db.SaveChanges();
                ChangeWeight(newuser, _weight);
                return newuser;
            }
        }

        public users Login(string _name, string _password)
        {
            using (var db = new db_modelContainer())
            {
                byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(_password);
                string passwordAsBytes = System.Convert.ToBase64String(toEncodeAsBytes);

                var x = db.usersSet;
                foreach (var s in x)
                {
                    if (s.name == _name && s.password == passwordAsBytes)
                    {
                        Users user = new Users(s.name, s.password, s.weight, s.joindate);
                        return s;
                    }
                }
                throw new LoginFailException("Inserted records are wrong!");
            }
        }

        public bool ChangePassword(string login, string newpassword)
        {
            using (var db = new db_modelContainer())
            {
                users u = new users();
                try
                {
                    u = db.usersSet.Single(a => a.name == login);
                }
                catch (Exception ex)
                {
                    throw new UserNotFoundException("I cannot find that user.");
                }

                byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(newpassword);
                string passwordAsBytes = System.Convert.ToBase64String(toEncodeAsBytes);

                u.password = passwordAsBytes;
                db.SaveChanges();
                return true;
            }
        }

        public bool ChangeWeight(users user, double weight)
        {
            using (var db = new db_modelContainer())
            {
                users u = new users();
                try
                {
                    u = db.usersSet.Single(a => a.name == user.name);
                }
                catch (Exception ex)
                {
                    throw new UserNotFoundException("I cannot find that user.");
                }
                u.weight = weight;
                db.SaveChanges();
                return true;
            }
        }

        public users GetUser(string username)
        {
            using (var db = new db_modelContainer())
            {
                users u = new users();
                try
                {
                    u = db.usersSet.Single(a => a.name == username);
                    return u;
                }
                catch (Exception ex)
                {
                    throw new UserNotFoundException("I cannot find that user.");
                }
                
            }
        }

    }
}
