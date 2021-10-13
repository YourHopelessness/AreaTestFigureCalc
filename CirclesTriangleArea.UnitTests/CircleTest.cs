using CirclesTriangleArea.Entity;
using System;
using Xunit;

namespace CirclesTriangleArea.UnitTests
{
    public class CircleTest
    {
        [Fact]
        public void InvalidCircle_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void CirclesAreEqual()
        {
            Circle circleFirst = new Circle(5);
            Circle circleSecond = new Circle(5);
            Assert.True(circleFirst.Equals(circleSecond));
        }

        [Fact]
        public void CircleNotEqual()
        {
            Circle circleFirst = new Circle(6);
            Circle circleSecond = new Circle(5);
            Assert.False(circleFirst.Equals(circleSecond));
        }
    }
}
