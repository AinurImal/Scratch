using Xunit;
using Scratch.Fundamentals;

namespace Scratch.UnitTests
{
    public class ErrorLoggerTests
    {
        [Fact]
        public void Log_WhenCalled_SetsTheLastErrorProperty()
        {
            // Arrange
            var logger = new ErrorLogger();
            // Act
            logger.Log("a");
            // Assert
            Assert.Equal("a", logger.LastError);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]

        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            // Arrange
            var logger = new ErrorLogger();
            //var eventRaised = false;
            // logger.ErrorLogged += (sender, id) => eventRaised = true;
            // Act
            //logger.Log("a");
            // Assert
            //Assert.True(eventRaised);
            Assert.Throws<ArgumentNullException>(() => logger.Log(error));
        }
        [Fact]
        public void Log_ValidError_RaisesErrorLoggedEvent()
        {
            // Arrange
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };

            // Act
            logger.Log("a");

            // Assert
            Assert.NotEqual(Guid.Empty, id);
        }
    }
}
