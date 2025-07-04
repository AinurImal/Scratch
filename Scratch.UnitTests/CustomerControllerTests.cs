using Xunit;
using Scratch.Fundamentals;

namespace Scratch.UnitTests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            // Arrange
            var controller = new CustomerController();
            // Act
            var result = controller.GetCustomer(0);
            // Assert
            Assert.IsType<NotFound>(result);
        }
        [Fact]
        public void GetCustomer_IdIsNotZero_ReturnsOk()
        {
            // Arrange
            var controller = new CustomerController();
            // Act
            var result = controller.GetCustomer(1);
            // Assert
            Assert.IsType<Ok>(result);
        }
    }
}
