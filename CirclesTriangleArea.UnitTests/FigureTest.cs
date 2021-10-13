using CirclesTriangleArea.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace CirclesTriangleArea.UnitTests
{
    public class FigureTest
    {
        /// <summary>
        /// Входные данные для тестов прямоугольника
        /// </summary>
        public static IEnumerable<object[]> RectanlgeData =>
            new List<object[]>
            {
                new object[] { -1, 5},
                new object[] { 2, -1}
            };

        /// <summary>
        /// Входные данные для тестов треугольника
        /// </summary>
        public static IEnumerable<object[]> TriangleData =>
            new List<object[]>
            {
                new object[] { -1, 5, 3},
                new object[] { 2, -1, 3},
                new object[] { 2, 5, -1},
                new object[] { 1, 10, 1},
            };


        [Fact]
        public void TriangleType_Rectangular()
        {
            var trig = new Triangle(3, 4, 5);
            Assert.Equal(TriangleType.Rectangled, trig.CheckTriangleType());
        }

        [Fact]
        public void TriangleType_Obtuse()
        {
            var trig = new Triangle(5, 6, 2);
            Assert.Equal(TriangleType.Obtuse, trig.CheckTriangleType());
        }

        [Fact]
        public void TriangleType_Acute()
        {
            var trig = new Triangle(5, 5, 5);
            Assert.Equal(TriangleType.AcuteAngled, trig.CheckTriangleType());
        }

        [Fact]
        public void InvalidCircle_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Theory]
        [MemberData(nameof(TriangleData))]
        public void InvalidTriangle_ThrowsArgumentException(params int[] data)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(data[0], data[1], data[2]));
        }

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
    }
}
