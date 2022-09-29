using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    public class CreateAccountFailException : Exception
    {
        public CreateAccountFailException() { }
        public CreateAccountFailException(string message) : base(message) { }
    }
    public class Users
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public double weight { get; set; }

        public Users()
        {
        }

        public Users(string n, string p, double w)
        {
            name = n;
            password = p;
            weight = w;
        }

        public void CreateAccount(string _username, double _weight, string _password, string _kcal_amount, string _notes)
        {
            using (var db = new db_modelContainer())
            {
                Daily_summary summary = new Daily_summary { kcal_amount = _kcal_amount, weight = _weight, notes = _notes };
                Users_dishes_gallery user_dishes = new Users_dishes_gallery { };

                var x = db.usersSet;
                foreach (var i in x)
                {
                    if (_username == i.name)
                        throw new CreateAccountFailException("Username is already occupied!");
                    return;
                }

                users newuser = new users { name = _username, weight = _weight, password = _password};

                
                db.usersSet.Add(newuser);
                db.SaveChanges();
            }
        }

        public users Login(string _name, string _password)
        {
            using (var db = new db_modelContainer())
            {
                var x = db.usersSet;
                foreach (var s in x)
                {
                    if (s.name == _name && s.password == _password)
                    {
                        Users user = new Users(s.name, s.password, s.weight);
                        return s;
                    }
                }
                return null;
            }
        }

        public bool ChangePassword(string login, string newpassword)
        {
            using (var db = new db_modelContainer())
            {
                users u = db.usersSet.Single(a => a.name == login);
                u.password = newpassword;
                db.SaveChanges();
                return true;
            }
        }

        public bool ChangeWeight(users user, double weight)
        {
            using (var db = new db_modelContainer())
            {
                users u = db.usersSet.Single(a => a.name == user.name);
                u.weight = weight;
                db.SaveChanges();
                return true;
            }
        }

    }
}
