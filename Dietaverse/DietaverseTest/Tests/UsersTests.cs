using Xunit;
using Dietaverse.Model;

namespace DietaverseTest.Tests
{
    public class UsersTests
    {
        [Fact]
        public void CreateAccount_GivenNotOccupiedUsername_CreateSucceed()
        {
            var user = new Users();
            //user.CreateAccount("test", 30, "password", "0", "null");
        }
    }
}
