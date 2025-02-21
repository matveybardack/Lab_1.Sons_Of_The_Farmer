using ClassLibraryShapes;
using System;
using System.Security.Cryptography;

// Вводимые периметр и стороны n-угольника
double p = 16;
int sides = 8;
void Test1()
{
    // Массив с фигурами
    string[] shapes = new string[] { "квадрата", "шестиугольника", "круга", "треугольника", "ромба", "прямоугольника", "n(8)-угольника"};
    // Массив с правильными ответами для p = 16 и sides = 8
    double[] myTests = new double[] { 16, 18.475, 20.372, 12.317, 13.856, 14.222, 19.314 };
    // Массив с ответами программы
    double[] squares = new double[7];
    // Заполнение массива с ответами программы
    // Округляем до 3 цифр после запятой
    squares[0] = Math.Round(ClassShapes.AreaSquare(p), 3);
    squares[1] = Math.Round(ClassShapes.HexagonSquare(p), 3);
    squares[2] = Math.Round(ClassShapes.CircleSquare(p), 3);
    squares[3] = Math.Round(ClassShapes.TriangleSquare(p), 3);
    squares[4] = Math.Round(ClassShapes.RombSquare(p), 3);
    squares[5] = Math.Round(ClassShapes.Square(p), 3);
    squares[6] = Math.Round(ClassShapes.PolygonSquare(p, sides), 3);
    // Сравнение ответов программы с ответами, полученными вручную
    for (int i = 0; i < myTests.Length; i++)
    {
        if (myTests[i] == squares[i]) 
            Console.WriteLine("Ответ корректен. Площадь {0} при периметре {1} равна {2}", shapes[i], p, squares[i]);
        else
            Console.WriteLine("Ответ некорректен. Площадь {0} при периметре {1} равна {2}", shapes[i], p, squares[i]);
    }
}
Test1();