using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesTriangleArea.Entity
{
    /// <summary>
    /// Фигура - прямоугольник
    /// </summary>
    public class Rectangle : Figure
    {
        public double SideFirst { get; init; }

        public double SideSecond { get; init; }

        public Rectangle(double first, double second)
        {
            SideFirst = first > 0 ? first
                : throw new ArgumentException("Длина стороны не может быть меньше 0");
            SideSecond = second > 0 ? second
                            : throw new ArgumentException("Длина стороны не может быть меньше 0");
        }

        public bool IsSquare() => SideFirst == SideSecond;
    }
}
