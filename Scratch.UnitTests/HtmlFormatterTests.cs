using Xunit;
using Scratch.Fundamentals;



namespace Scratch.UnitTests
{
    public class HtmlFormatterTests
    {
        [Fact]
        public void FormatAsBold_WhenCalled_ShouldEnclosedTheStringWithStrongElement()
        {
            // Arrange
            var formatter = new HtmlFormatter();

            // Act
            var result = formatter.FormatAsBold("Hello, World!");

            // Assert
            Assert.Equal("<strong>Hello, World!</strong>", result);
        }
    }
}
