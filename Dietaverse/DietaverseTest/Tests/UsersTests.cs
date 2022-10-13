using Xunit;
using Dietaverse.Model;
using Moq;
using AutoFixture.Xunit2;
using Dietaverse.Database;
using System.Data.Entity;
using System.Collections.Generic;

namespace DietaverseTest.Tests
{
    public class UsersTests
    {
        [Theory, AutoData]
        public void CreateAccount_GivenNotOccupiedUsername_CreateSucceed()
        {

            string expectedLogin = "test";
            string expectedPassword = "test";
            double expectedWeight = 30;

            //var userfromdb = new users { name = expectedLogin, password = expectedPassword, weight = expectedWeight };
            //var dbset = new Mock<DbSet<users>>();
            //dbset.Setup(x => x.Add(userfromdb));
            //^^ mock usersSeta 
            List<users> users = new List<users>();
            //users.Add(new users() {name= expectedLogin, password=expectedPassword, weight= expectedWeight });


            //vv 
            var dbMock = new Mock<db_modelContainer>();
            //dbMock.Setup(x=>x.usersSet).Returns(dbset);
            dbMock.CallBase = true;
            

            var userMock = new Mock<Users>();
            userMock.Object.ChangeDB(dbMock.Object);
            userMock.CallBase = true;
            dbMock.Setup(x => x.usersSet.Add(It.IsAny<users>()));
            dbMock.Setup(x => x.SaveChanges()).Returns(1);
            userMock.Setup(x => x.LoadUsers()).Returns(users);
            userMock.Setup(x => x.CleanUpUsers()).Returns(true);
            //dbMock.Setup(x => x.usersSet).Returns(dbset);
            //dbMock.Setup(x => x.usersSet.Add(userMock));
            //dbMock.Setup(x => x.Object.SaveChanges());
            var newuser = userMock.Object.CreateAccount(expectedLogin, expectedWeight, expectedPassword);

            /////////////

            //var usersService = new UsersService(userContextMock.Object);

            // Act
            //var user = usersMock.AddUser(expectedLogin, expectedName, expectedSurname);

            // Assert
            Assert.Equal(expectedLogin, userMock.Object.name);
            Assert.Equal(expectedPassword, userMock.Object.password);
            Assert.Equal(expectedWeight, userMock.Object.weight);

            //usersMock.Verify(x => x.SaveChanges(), Times.Once);
        }

   
    }
}
