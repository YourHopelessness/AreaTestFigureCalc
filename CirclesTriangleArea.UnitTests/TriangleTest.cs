using CirclesTriangleArea.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace CirclesTriangleArea.UnitTests
{
    public class TriangleTest
    {
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

        [Theory]
        [MemberData(nameof(TriangleData))]
        public void InvalidTriangle_ThrowsArgumentException(params int[] data)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(data[0], data[1], data[2]));
        }

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

        public static IEnumerable<object[]> EqualsTriangles =>
            new List<object[]>
            {
                new object[] { new Triangle(3, 4, 5), new Triangle(3, 4, 5) },
                new object[] { new Triangle(3, 4, 5), new Triangle(5, 3, 4) },
                new object[] { new Triangle(3, 4, 5), new Triangle(4, 5, 3) },
                new object[] { new Triangle(3, 4, 5), new Triangle(4, 3, 5) },
                new object[] { new Triangle(3, 4, 5), new Triangle(3, 5, 4) },
                new object[] { new Triangle(3, 4, 5), new Triangle(5, 4, 3) }
            };

        [Theory]
        [MemberData(nameof(EqualsTriangles))]
        public void TrianglesAreEqual(params Triangle[] triangles)
        {
            Assert.True(triangles[0].Equals(triangles[1]));
        }

        public static IEnumerable<object[]> NotEqualsTriangles =>
           new List<object[]>
           {
                new object[] { new Triangle(3, 4, 5), new Triangle(2, 4, 5) },
                new object[] { new Triangle(3, 4, 5), new Triangle(3, 3, 5) },
                new object[] { new Triangle(3, 4, 5), new Triangle(3, 4, 6) }
           };

        [Theory]
        [MemberData(nameof(NotEqualsTriangles))]
        public void TrianglesNotEqual(params Triangle[] triangles)
        {
            Assert.False(triangles[0].Equals(triangles[1]));
        }
    }
}
