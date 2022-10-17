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

        //todo: changepassword
        public void ChangePassword_GivenPresentUsername_ChangeSucceed()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";


        }

        public void ChangePassword_GivenAbsentUsername_ChangeFailure()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";


        }

        //todo: changeweight

        public void ChangeWeight_GivenPresentUser_ChangeSucceed()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";


        }

        public void ChangeWeight_GivenAbsentUser_ChangeFailure()
        {
            string expectedLogin = "UsersTest";
            string expectedPassword = "test";


        }

    }
}
