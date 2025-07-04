using Xunit;

namespace Scratch.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            // Arrange
            int number = 15;
            // Act
            var result = Scratch.Fundamentals.FizzBuzz.GetOutput(number);
            // Assert
            Assert.Equal("FizzBuzz", result);
        }
        [Fact]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnsFizz()
        {
            // Arrange
            int number = 9;
            // Act
            var result = Scratch.Fundamentals.FizzBuzz.GetOutput(number);
            // Assert
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnsBuzz()
        {
            // Arrange
            int number = 10;
            // Act
            var result = Scratch.Fundamentals.FizzBuzz.GetOutput(number);
            // Assert
            Assert.Equal("Buzz", result);
        }
        [Fact]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnsTheSameNumber()
        {
            // Arrange
            int number = 7;
            // Act
            var result = Scratch.Fundamentals.FizzBuzz.GetOutput(number);
            // Assert
            Assert.Equal("7", result);
        }
    }
}
