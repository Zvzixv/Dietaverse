using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class UnitTest1
    {
        [Fact]
        [AutoRollback]
        public void CreateAccount_GivenNotOccupiedUsername_CreateSucceed()
        {
            string expectedLogin = "testdupa";
            string expectedPassword = "test";
            double expectedWeight = 30;

            Users user = new Users();
            users createduser = user.CreateAccount(expectedLogin, expectedWeight, expectedPassword);

            // Assert
            Assert.Equal(expectedLogin, createduser.name);
            Assert.Equal(expectedPassword, createduser.password);
            Assert.Equal(expectedWeight, createduser.weight);

        }
    }
}
