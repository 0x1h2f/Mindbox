using MindBox.Library;
using System;
using Xunit;

namespace MindBox.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Circle circle = new Circle(5);

            double result = Calculator.GetSquare(circle);

            Assert.Equal(78.5398, Math.Round(result, 4));
        }

        [Fact]
        public void Test2()
        {
            Triangle triangle = new Triangle(5, 9, 6);

            double result = Calculator.GetSquare(triangle);

            Assert.Equal(14.1421, Math.Round(result, 4));
        }


        [Fact]
        public void Test3()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            bool result = triangle.IsRightAngled;

            Assert.True(result);
        }
    }
}
