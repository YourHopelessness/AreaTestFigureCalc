using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesTriangleArea.Entity
{
    /// <summary>
    /// Абстрактный класс фигуры, для задания иерархии наследования
    /// </summary>
    public abstract class Figure : IEquatable<Figure>
    {
        public bool Equals(Figure other)
        {
            if (other == null) return false;
            return true;
        }
    }
}
