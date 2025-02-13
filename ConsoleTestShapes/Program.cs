using ClassLibraryShapes;
using System;
using System.Security.Cryptography;

double p = 16;
int sides = 8;
void Test1()
{
    string[] shapes = new string[] { "квадрата", "шестиугольника", "круга", "треугольника", "ромба", "прямоугольника", "n(8)-угольника"};
    double[] myTests = new double[] { 16, 18.475, 20.372, 12.317, 13.856, 14.222, 19.314 };
    double[] squares = new double[7];
    squares[0] = Math.Round(ClassShapes.AreaSquare(p), 3);
    squares[1] = Math.Round(ClassShapes.HexagonSquare(p), 3);
    squares[2] = Math.Round(ClassShapes.CircleSquare(p), 3);
    squares[3] = Math.Round(ClassShapes.TriangleSquare(p), 3);
    squares[4] = Math.Round(ClassShapes.RombSquare(p), 3);
    squares[5] = Math.Round(ClassShapes.Square(p), 3);
    squares[6] = Math.Round(ClassShapes.PolygonSquare(p, sides), 3);
    for (int i = 0; i < myTests.Length; i++)
    {
        if (myTests[i] == squares[i]) 
            Console.WriteLine("Ответ корректен. Площадь {0} при периметре {1} равна {2}", shapes[i], p, squares[i]);
        else
            Console.WriteLine("Ответ некорректен. Площадь {0} при периметре {1} равна {2}", shapes[i], p, squares[i]);
    }
}
Test1();