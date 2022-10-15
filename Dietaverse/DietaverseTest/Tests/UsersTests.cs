using Xunit;
using Dietaverse.Model;
using Moq;
using AutoFixture.Xunit2;
using Dietaverse.Database;
using System.Data.Entity;
using System.Collections.Generic;
using AutoRollbackExample;

namespace DietaverseTest.Tests
{
    public class UsersTests
    {
        [Fact]
        //[AutoRollback]
        public void CreateAccount_GivenNotOccupiedUsername_CreateSucceed()
        {
            string expectedLogin = "test";
            string expectedPassword = "test";
            double expectedWeight = 30;

            Users user = new Users();
            users createduser = user.CreateAccount(expectedLogin, expectedWeight,expectedPassword);
            
            // Assert
            Assert.Equal(expectedLogin, createduser.name);
            Assert.Equal(expectedPassword, createduser.password);
            Assert.Equal(expectedWeight, createduser.weight);

        }

   
    }
}
