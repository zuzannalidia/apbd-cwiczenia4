using System;
using Xunit;
using LegacyApp;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
        {
            // Arrange
            var userService = new UserService();

            // Act
            var result = userService.AddUser(null, "Kowalski", "kowalski@kowalski.pl", DateTime.Parse("1982-03-21"), 1);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AddUser_ReturnsFalseWhenLastNameIsEmpty()
        {
            // Arrange
            var userService = new UserService();

            // Act
            var result = userService.AddUser("Jan", null, "kowalski@kowalski.pl", DateTime.Parse("1982-03-21"), 1);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AddUser_ReturnsFalseWhenEmailIsInvalid()
        {
            // Arrange
            var userService = new UserService();

            // Act
            var result = userService.AddUser("Jan", "Kowalski", "invalidemail", DateTime.Parse("1982-03-21"), 1);
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AddUser_ReturnsFalseWhenAgeIsUnder21()
        {
            // Arrange
            var userService = new UserService();

            // Act
            var result = userService.AddUser("Jan", "Kowalski", "kowalski@kowalski.pl", DateTime.Now.AddYears(-20), 1);
            
            // Assert
            Assert.False(result);
        }

    }
}