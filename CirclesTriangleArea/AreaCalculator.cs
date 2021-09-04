using CirclesTriangleArea.Entity;
using System;

namespace CirclesTriangleArea
{
    /// <summary>
    /// Интерфейс калькулятора
    /// </summary>
    public interface IAreaCalculation
    {
        /// <summary>
        /// Функция расчета площади фигуры
        /// </summary>
        /// <param name="figure">фигура типа Circle или Triangle</param>
        /// <returns>площадь заданной фигуры</returns>
        /// <exception cref="NotImplementedException">Расчет для данного типа фигуры пока не возможен</exception>
        double CalrulateArea(Figure figure);
    }

    /// <summary>
    /// Калькулятор площади,
    /// считает площадь с точнстью до 5 знаков
    /// </summary>
    public class AreaCalculator : IAreaCalculation
    {
        private double CircleCalculator(Circle circle) =>
            Math.PI * circle.Radius * circle.Radius;
        private double TriangleCalculator(Triangle triangle) =>
            triangle.SideFirst * triangle.SideSecond * 
                Math.Sin(triangle.FSAngle) / 2;
        private double RectangleCalculator(Rectangle rec) =>
           rec.SideFirst * rec.SideSecond;

        /// <inheritdoc></inheritdoc>
        public double CalrulateArea(Figure figure) => 
            Math.Round(figure switch
        {
            Circle => CircleCalculator((Circle)figure),
            Triangle => TriangleCalculator((Triangle)figure),
            Rectangle => RectangleCalculator((Rectangle)figure),
            _ => throw new NotImplementedException("Пока нет реализации для этого типа")
        }, 5);
    }
}
