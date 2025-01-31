using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShapes
{
    /// <summary>
    /// Класс фигур
    /// Вычисление площади фигур при заданном периметре
    /// </summary>
    public static class ClassShapes
    {
        /// <summary>
        /// Вычисление площади правильного шестиугольника
        /// при заданном периметре
        /// </summary>
        /// <param name="perimetr">периметр правильного шестиугольника</param>
        /// <returns>площадь правильного шестиугольника</returns>
        public static double HexagonSquare(double perimetr)
        {
            double square = 0;
            square = (3 * Math.Sqrt(3) * Math.Pow((perimetr / 6), 2)) / 2;
            return square;
        }
    }
}
