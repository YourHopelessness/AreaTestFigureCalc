using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesTriangleArea.Entity
{
    /// <summary>
    /// Типы трегольников
    /// </summary>
    public enum TriangleType
    {
        /// <summary>
        /// Остроугольный
        /// </summary>
        AcuteAngled, 
        /// <summary>
        /// Прямоугольный
        /// </summary>
        Rectangled,
        /// <summary>
        /// Тупоугольный
        /// </summary>
        Obtuse 
    }
    /// <summary>
    /// Фигура - треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Длина одной стороны треугольнка
        /// </summary>
        public double SideFirst { get; init; }
        /// <summary>
        /// Длина второй стороны треугольника
        /// </summary>
        public double SideSecond { get; init; }
        /// <summary>
        /// Длина третьей стороны треугольника
        /// </summary>
        public double SideThird { get; init; }
        /// <summary>
        /// Угол между первой и второй стороной
        /// </summary>
        public double FSAngle { get; init; }
        /// <summary>
        /// Угол между второй и третьей стороной
        /// </summary>
        public double STAngle { get; init; }
        /// <summary>
        /// Угол между первой и третьей стороной
        /// </summary>
        public double TFAngle { get; init; }

        /// <summary>
        /// Инициализация треугольника по трем стонам
        /// </summary>
        /// <param name="sideFirst">Первая сторона треугольника</param>
        /// <param name="sideSecond">Вторая сторона треугольника</param>
        /// <param name="sideThird">Третья сторона</param>
        public Triangle(double sideFirst, double sideSecond, double sideThird)
        {
            SideFirst = sideFirst > 0 ? sideFirst
                : throw new ArgumentException("Длина стороны не может быть меньше 0");
            SideSecond = sideSecond > 0 ? sideSecond
                : throw new ArgumentException("Длина стороны не может быть меньше 0");
            SideThird = sideThird > 0 ? sideThird
                : throw new ArgumentException("Длина стороны не может быть меньше 0");

            FSAngle =
               Math.Acos((Math.Pow(SideFirst, 2) +
                          Math.Pow(SideSecond, 2) -
                          Math.Pow(SideThird, 2)) /
                         (2 * SideFirst * SideSecond));
            STAngle =
               Math.Acos((Math.Pow(SideThird, 2) +
                          Math.Pow(SideSecond, 2) -
                          Math.Pow(SideFirst, 2)) /
                         (2 * SideThird * SideSecond));
            TFAngle =
               Math.Acos((Math.Pow(SideFirst, 2) +
                          Math.Pow(SideThird, 2) -
                          Math.Pow(SideSecond, 2)) /
                         (2 * SideFirst * SideThird));
            if (double.IsNaN(FSAngle) ||
                double.IsNaN(STAngle) ||
                double.IsNaN(TFAngle))
                throw new ArgumentException("Треугольника с такими параметрами не существует");
        }

        /// <summary>
        /// Проверка какого типа треугольник
        /// </summary>
        /// <returns>Тип треугольника из перечисления TriangleType</returns>
        public TriangleType CheckTriangleType() =>
            Math.Max(Math.Max(FSAngle, TFAngle), STAngle) > Math.PI / 2 ? TriangleType.Obtuse :
            Math.Max(Math.Max(FSAngle, TFAngle), STAngle) == Math.PI / 2 ? TriangleType.Rectangled :
            TriangleType.AcuteAngled;

        public bool Equals(Triangle other)
        {
            if (base.Equals(other))
            {
                if (this.SideFirst == other.SideFirst &&
                    this.SideSecond == other.SideSecond &&
                    this.SideThird == other.SideThird ||
                    this.SideFirst == other.SideSecond &&
                    this.SideSecond == other.SideThird &&
                    this.SideThird == other.SideFirst ||
                    this.SideFirst == other.SideThird &&
                    this.SideSecond == other.SideFirst &&
                    this.SideThird == other.SideSecond)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
