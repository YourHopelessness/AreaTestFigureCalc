using CirclesTriangleArea.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace CirclesTriangleArea.UnitTests
{
    public class RectangleTest
    {
        public static IEnumerable<object[]> RectanlgeData =>
            new List<object[]>
            {
                new object[] { -1, 5},
                new object[] { 2, -1}
            };

        [Theory]
        [MemberData(nameof(RectanlgeData))]
        public void InvalidRectangle_ThrowsArgumentException(params int[] data)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(data[0], data[1]));
        }

        [Fact]
        public void IsRectangeSquare()
        {
            var rec = new Rectangle(5, 5);
            Assert.True(rec.IsSquare());
        }

        public static IEnumerable<object[]> EqualRectangles =>
            new List<object[]>
            {
                new object[] {new Rectangle(1, 5), new Rectangle(1, 5)},
                new object[] {new Rectangle(5, 1), new Rectangle(1, 5)}
            };

        [Theory]
        [MemberData(nameof(EqualRectangles))]
        public void IsRectangleEquals(params Rectangle[] rectangles)
        {
            Assert.True(rectangles[0].Equals(rectangles[1]));
        }


        public static IEnumerable<object[]> NotEqualRectangles =>
            new List<object[]>
            {
                new object[] {new Rectangle(1, 6), new Rectangle(1, 5)},
                new object[] {new Rectangle(6, 1), new Rectangle(1, 5)}
            };

        [Theory]
        [MemberData(nameof(NotEqualRectangles))]
        public void RectanglesIsNotEquals(params Rectangle[] rectangles)
        {
            Assert.False(rectangles[0].Equals(rectangles[1]));
        }
    }
}
