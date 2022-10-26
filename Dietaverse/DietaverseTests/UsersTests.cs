using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class UsersTests
    {
        [Fact]
        [AutoRollback]
        public void CreateAccount_GivenNotOccupiedUsername_CreateSucceed()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";
            double expectedWeight = 30;

            Users user = new Users();
            users createduser = user.CreateAccount(expectedLogin, expectedWeight, expectedPassword);

            // Assert
            Assert.Equal(expectedLogin, createduser.name);
            Assert.Equal(expectedPassword, createduser.password);
            Assert.Equal(expectedWeight, createduser.weight);

        }

        [Fact]
        [AutoRollback]
        public void CreateAccount_GivenOccupiedUsername_CreateFailure()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";
            double expectedWeight = 30;

            Users user = new Users();
            user.CreateAccount(expectedLogin, expectedWeight, expectedPassword);
            try
            {
                user.CreateAccount(expectedLogin, expectedWeight, expectedPassword);
            }

            // Assert
            catch (CreateAccountFailException ex)
            {
                Assert.True(true);
            }

        }

        [Fact]
        [AutoRollback]
        public void Login_GivenPresentUsername_LoginSucceed()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";
            double expectedWeight = 30;

            Users user = new Users();
            user.CreateAccount(expectedLogin, expectedWeight, expectedPassword);
            users loginuser = new users();

            try
            {
                loginuser = user.Login(expectedLogin, expectedPassword);
            }
            catch (LoginFailException ex)
            {
                Assert.True(false);
                return;
            }

            Assert.True(true);
            Assert.Equal(loginuser.name, expectedLogin);

        }

        [Fact]
        [AutoRollback]
        public void Login_GivenAbsentUsername_LoginFailure()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";

            Users user = new Users();

            users loginuser = new users();

            try
            {
                loginuser = user.Login(expectedLogin, expectedPassword);
            }
            catch (Dietaverse.Model.LoginFailException ex)
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);

        }


        [Fact]
        [AutoRollback]
        public void ChangePassword_GivenPresentUsername_ChangeSucceed()
        {
            string username = "UsersTest";
            string password = "pass";
            double weight = 10;

            //users testuser = new users(); //{ name = username, password = password, weight = weight };
            Users t = new Users();
            users testuser = t.CreateAccount(username, 10, password);

            string newpassword = "newpass";

            try
            {
                t.ChangePassword(username, newpassword);
            }
            catch
            {
                Assert.True(false);
                return;
            }

            Assert.Equal(newpassword, testuser.password);
        }

        [Fact]
        [AutoRollback]
        public void ChangePassword_GivenAbsentUsername_ChangeFailure()
        {
            string username = "UsersTest";
            string password = "pass";
            double weight = 10;

            users testuser = new users();
            Users t = new Users();
            //t.CreateAccount("UsersTest", 10, "passwprd");

            string newpassword = "newpass";

            try
            {
                t.ChangePassword(username, newpassword);
            }
            catch
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);

        }

        [Fact]
        [AutoRollback]
        public void ChangeWeight_GivenPresentUser_ChangeSucceed()
        {
            string username = "UsersTest";
            string password = "pass";
            double weight = 10;


            Users t = new Users();
            users testuser = t.CreateAccount("UsersTest", 10, "passwprd");

            double newweight = 30;

            try
            {
                t.ChangeWeight(testuser, newweight);
            }
            catch
            {
                Assert.True(false);
                return;
            }

            Assert.Equal(newweight, testuser.weight);


        }
        [Fact]
        [AutoRollback]
        public void ChangeWeight_GivenAbsentUser_ChangeFailure()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";

            Users t = new Users();
            users testuser = new users();
            //users testuser = t.CreateAccount("UsersTest", 10, "passwprd");

            double newweight = 30;

            try
            {
                t.ChangeWeight(testuser, newweight);
            }
            catch
            {
                Assert.True(true);
                return;
            }

            Assert.True(false);



        }

    }
}
