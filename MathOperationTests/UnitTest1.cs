using System;
using Xunit;

namespace MathOperationTests
{
  public class OperationTests
    {
        [Fact]
        public void AddTwoNumbers_ReturnsSum()
        {
            var num1 = 10;
            var num2 = 20;
            var result = MathOperations.MathOperation.Add(num1, num2);
            Assert.Equal(30, result);
        }

        [Fact]
        public void SubtractTwoNumbers_ReturnsDifference()
        {
            var num1 = 20;
            var num2 = 10;
            var result = MathOperations.MathOperation.Subtract(num1, num2);
            Assert.Equal(10, result);
        }

        [Fact]
        public void MultiplyTwoNumbers_ReturnsProduct()
        {
            var num1 = 10;
            var num2 = 20;
            var result = MathOperations.MathOperation.Multiply(num1, num2);
            Assert.Equal(200, result);
        }

        [Fact]
        public void DivideTwoNumbers_ReturnsQuotient()
        {
            var num1 = 20;
            var num2 = 10;
            var result = MathOperations.MathOperation.Divide(num1, num2);
            Assert.Equal(2, result);
        }
    }
}
