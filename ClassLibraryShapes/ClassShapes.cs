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
        /// <param name="perimeter">периметр правильного шестиугольника</param>
        /// <returns>площадь правильного шестиугольника</returns>
        public static double HexagonSquare(double perimeter) // Матвей
        {
            double square = 0;
            square = (3 * Math.Sqrt(3) * Math.Pow((perimeter / 6), 2)) / 2;
            return square;
        }

        /// <summary>
        /// Вычисление площади круга
        /// при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр круга</param>
        /// <returns>площадь круга</returns>
        public static double CircleSquare(double perimeter) // Егор
        {
            double circleSquare = 0;
            circleSquare = Math.Pow(perimeter, 2) / (4 * Math.PI);
            return circleSquare;
        }

        /// <summary>
        /// Площадь правильного треугольника при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр правильного треугольника</param>
        /// <returns>площадь правильного треугольника</returns>
        public static double TriangleSquare(double perimeter) // Амон
        {
            double treug_square = 0;
            treug_square = ((perimeter / 3) * (perimeter / 3) * Math.Sqrt(3)) / 4;
            return treug_square;
        }

        /// <summary>
        /// Площадь квадарата при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр квадарата</param>
        /// <returns>площадь квадрата</returns>
        public static double AreaSquare( double perimeter) // Амон
        {
            double kvadrat_square = 0;
            kvadrat_square = (perimeter / 4) * (perimeter / 4);
            return kvadrat_square;
        }


        /// <summary>
        /// Плошадь ромба из 2 равносторонних треугольников при заданом периметре
        /// </summary>
        /// <param name="perimeter">периметр ромба из 2 равносторонних треугольников</param>
        /// <returns>площадь ромба из 2 равносторонних треугольников</returns>
        public static double RombSquare(double perimeter) // Артем
        {
            double square = (perimeter / 4) * (perimeter / 4) * Math.Sqrt(3) / 2;
            return square;
        }
        

        /// <summary>
        /// Плошадь прямоугольника при заданом периметре
        /// </summary>
        /// <param name="perimeter">периметр прямоугольника</param>
        /// <returns>площадь прямоугольника</returns>
        public static double Square(double perimeter) // Макс
        {
            double square = (perimeter * perimeter) / 18;
            return square;
        }
    }
}
