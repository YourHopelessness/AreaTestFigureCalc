using CirclesTriangleArea.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace CirclesTriangleArea.UnitTests
{
    public class AreaCalculatorTest
    {

        [Fact]
        public void Circle_CorrectArea()
        {
            AreaCalculator calc = new();
            var circle = new Circle(1);
            Assert.Equal(3.14159, calc.CalrulateArea(circle));
        }

        [Fact]
        public void Rectangle_CorrectArea()
        {
            AreaCalculator calc = new();
            var rec = new Rectangle(1, 2);
            Assert.Equal(2, calc.CalrulateArea(rec));
        }

        [Fact]
        public void Triangle_CorrectArea()
        {
            AreaCalculator calc = new();
            var trig = new Triangle(5, 8, 5);
            Assert.Equal(12, calc.CalrulateArea(trig));
        }
    }
}
