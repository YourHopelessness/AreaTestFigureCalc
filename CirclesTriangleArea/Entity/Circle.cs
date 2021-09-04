using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesTriangleArea.Entity
{
    /// <summary>
    /// Фигура - круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга - неотрицатеьное число
        /// </summary>
        public double Radius { get; init; }

        /// <summary>
        /// Инициализация круга
        /// </summary>
        /// <param name="radius">радиус круга</param>
        public Circle(double radius) =>
            Radius = radius > 0 ? radius 
              : throw new ArgumentException("Радиус не может быть меньше 0");
    }
}
