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

        /// <summary>
        /// Вычисление площади круга
        /// при заданном периметре
        /// </summary>
        /// <param name="perimetr">периметр круга</param>
        /// <returns>площадь круга</returns>
        public static double CircleSquare(double perimeter)
        {
            double circleSquare = 0
            circleSquare = Math.Pow(perimeter, 2) / (4 * Math.PI);
            return circleSquare;
        }

        /// <summary>
        /// Плошадь правильного треугольника при заданом периметре
        /// </summary>
        /// <param name="perimetr">периметр правильного треугольника</param>
        /// <returns>площадь правильного треугольника</returns>
        public static double TriangleSquare(double perimetr)
        {
            double treug_square = 0;
            treug_square = ((perimetr / 3) * (perimetr / 3) * Math.Sqrt(3)) / 4;
            return treug_square;
        }

        /// <summary>
        /// Плошадь квадарата при заданом периметре
        /// </summary>
        /// <param name="perimetr">периметр квадарата</param>
        /// <returns>площадь квадрата</returns>
        public static double AreaSquare( double perimetr)
        {
            double kvadrat_square = 0;
            kvadrat_square = (perimetr / 4) * (perimetr / 4);
            return kvadrat_square;
        }
    }
}
