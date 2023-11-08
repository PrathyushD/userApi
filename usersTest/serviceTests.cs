using FluentAssertions;
using NSubstitute;
using userApplication;
using userCore.Models;

namespace usersTest
{
    public class UsersServiceTests
    {
        [Fact]
        public async Task GetUsers_Returns_Users()
        {
            // Arrange
            var usersRepository = Substitute.For<IusersRepository>();
            var usersService = new UserService(usersRepository);

            var expectedUsers = new List<users>
        {
            new users { userId = 1, userName = "User 1" },
            new users { userId = 2, userName = "User 2" },
            new users { userId = 3, userName = "User 3" }

        };

            usersRepository.GetUsers(Arg.Any<string>()).ReturnsForAnyArgs(Task.FromResult(expectedUsers));

            // Act
            var result = await usersService.GetUsers();

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedUsers);
            result.Should().HaveCount(3);
        }


        //    [Fact]
        //    public async Task GetUsers_ReturnsListOfUsers()
        //    {
        //        // Arrange
        //        var userService = Substitute.For<UserService>();
        //        var Users =  new List<users>
        //        {
        //            new users { userId = 1, userName = "User 1" },
        //            new users { userId = 2, userName = "User 2" }
        //            // Add more fake users as needed
        //        };



        //        // Act
        //        var result = await userService.GetUsers();

        //        // Assert
        //        result.Should().NotBeNull(); // Check if the result is not null
        //        result.Should().BeEquivalentTo(Users); // Check if the returned list matches the provided fake users list
        //    }
        //}
    }
}

 
    
    



