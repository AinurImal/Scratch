namespace Scratch.UnitTests;
using Scratch.Fundamentals;
using Xunit;

public class OrderTests
{
    
    [Fact]
    public void CanBeCancelledBy_AdminUser_ReturnsTrue()
    {
        // Arrange
        var admin = new User { Id = 1, IsAdmin = true };
        var order = new Order { PlacedBy = new User { Id = 2, IsAdmin = false } };

        // Act
        var result = order.CanBeCancelledBy(admin);

        // Assert
        Assert.True(result);
    }
    [Fact]
    public void CanBeCancelledBy_SameUserCancellingTheOrder_ReturnsTrue()
    {
        // Arrange
        var user = new User();
        var order = new Order { PlacedBy = user };
        // Act
        var result = order.CanBeCancelledBy(user);
        // Assert
        Assert.True(result);
    }
    [Fact]
    public void CanBeCancelledBy_AnotherUserCancellingTheOrder_ReturnsFalse()
    {
        // Arrange
        var user1 = new User { Id = 1, IsAdmin = false };
        var user2 = new User { Id = 2, IsAdmin = false };
        var order = new Order { PlacedBy = user1 };
        // Act
        var result = order.CanBeCancelledBy(user2);
        // Assert
        Assert.False(result);
    }
}


