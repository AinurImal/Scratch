using Xunit;
using Scratch.Fundamentals;
using Math = Scratch.Fundamentals.Math;
using NUnit.Framework;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace Scratch.UnitTests
{
    public class MathTests
    {
        private Math _math;
        public MathTests()
        {
            _math = new Math();
        }

        [Fact]
        //[Fact(Skip ="This test is ignored for demonstration purposes.")]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            // Act
            var result = _math.Add(1, 2);
            // Assert
            Assert.Equal(3, result);
            //Assert.NotNull(_math);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 2)]
        public void Max_WhenCalled_ReturnsTheGreaterArguments(int a,int b, int expectedResult)
        {
            // Act
            var result = _math.Max(a, b);
            // Assert
            Assert.Equal(2, expectedResult);
        }
        [Fact]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnsOddNumbersUpToLimit()
        {
            
            // Act
            var result = _math.GetOddNumbers(5);
            // Assert
            //Assert.NotEmpty(result);
            Assert.Equivalent(result, new[] { 1, 3, 5 });
        }
    }
}
