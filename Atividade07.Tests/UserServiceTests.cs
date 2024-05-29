namespace Atividade07.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void SaveUser_WithEmptyEmail_ThrowsNewArgumentNullException()
        {
            var user = new User("Victor", "");
            var db = new Database();
            var userService = new UserService(db);

            var exception = Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
            Assert.Equal(exception.Message, "User must have a name and email");
        }

        [Fact]
        public void SaveUser_WithEmptyName_ThrowsNewArgumentNullException()
        {
            var user = new User("", "victor@email.com");
            var db = new Database();
            var userService = new UserService(db);

            var exception = Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
            Assert.Equal(exception.Message, "User must have a name and email");
        }
    }
}