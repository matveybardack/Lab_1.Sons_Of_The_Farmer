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
            //сторона шестиугольника
            double a = perimeter / 6;

            //синус угла треугольника, построенного на стороне шестиугольника и центре вписанной окружности
            double sin = Math.Sqrt(3) / 2;

            //площадь треугольника, построенного на стороне шестиугольника и центре вписанной окружности
            double triangle_square = a * sin / 2;

            //площадь шестиугольника
            double square = triangle_square * 6;
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
            double circleSquare = Math.Pow(perimeter, 2) / (4 * Math.PI);
            return circleSquare;
        }

        /// <summary>
        /// Площадь правильного треугольника при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр правильного треугольника</param>
        /// <returns>площадь правильного треугольника</returns>
        public static double TriangleSquare(double perimeter) // Амон
        {
            //сторона треугольника
            double a = perimeter / 3;

            //синус угла треугольника
            double sin = Math.Sqrt(3) / 2;

            //площадь треугольника
            double treug_square = Math.Pow(a, 2) * sin / 2;
            return treug_square;
        }

        /// <summary>
        /// Площадь квадарата при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр квадарата</param>
        /// <returns>площадь квадрата</returns>
        public static double AreaSquare( double perimeter) // Амон
        {
            //сторона квадрата
            double a = perimeter / 4;

            //площадь квадрата
            double kvadrat_square = Math.Pow(a, 2);
            return kvadrat_square;
        }


        /// <summary>
        /// Плошадь ромба из 2 равносторонних треугольников при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр ромба из 2 равносторонних треугольников</param>
        /// <returns>площадь ромба из 2 равносторонних треугольников</returns>
        public static double RombSquare(double perimeter) // Артем
        {
            //сторона ромба
            double a = perimeter / 4;

            //синус угла ромба
            double sin = Math.Sqrt(3) / 2;

            //площадь ромба
            double square = Math.Pow(a, 2) * sin;
            return square;
        }
        

        /// <summary>
        /// Плошадь прямоугольника при заданном периметре
        /// </summary>
        /// <param name="perimeter">периметр прямоугольника</param>
        /// <returns>площадь прямоугольника</returns>
        public static double Square(double perimeter) // Макс
        {
            //меньшая сторона прямоугольника
            double less_a = perimeter / 6;

            //большая сторона прямоугольника
            double more_a = less_a * 2;

            //площадь прямоугольника
            double square = less_a * more_a;
            return square;
        }

        ///<summary>
        ///Площадь правильного многоугольника
        ///при заданном периметре
        ///</summary>
        ///<param name="perimeter">периметр правильного многоугольника</param>
        ///<returns>площадь правильного многоугольника</returns>
        public static double PolygonSquare(double perimeter, int sides) //Матвей
        {
            //длина стороны
            double a = perimeter / sides;

            //котангенс угла при вершине, находящейся в центре вписанной в n-угольник окружности, прямоугольного треугольника,
            //построенного на стороне n-угольника
            double ctg_alfa = 1 / Math.Tan(Math.PI / sides);

            //радиус вписанной окружности
            double r = (a / 2) * ctg_alfa;

            //площадь треугольника, построенного на стороне n-угольника и центре вписанной в n-угольник окружности
            double triangle_square = r * a / 2;

            //площадь правильного многоугольника
            double square = triangle_square * sides;

            return square;
        }
    }
}
