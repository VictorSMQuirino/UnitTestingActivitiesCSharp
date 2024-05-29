using NSubstitute;

namespace Atividade10.Tests
{
    public class UserManagerTests
    {
        [Fact]
        public void FetchUserInfo_WithValidId_ReturnNewUser()
        {
            var userService = Substitute.For<IUserService>();
            var userManager = new UserManager(userService);

            userService.GetUserInfo(1).Returns(new User("name", "email"));

            var user = userManager.FetchUserInfo(1);

            Assert.IsType<User>(user);
            Assert.Equal(user.Name, "name");
            Assert.Equal(user.Email, "email");
        }
    }
}
