using ClassLibraryShapes;
using System;

void Test1()
{
    double p = 16;
    double s = ClassShapes.AreaSquare(p);
    Console.WriteLine("Площадь квадрата = " + s.ToString());
}
Test1();
void Test2()
{
    double p = 2.5;
    double s = ClassShapes.AreaSquare(p);
    Console.WriteLine("Площадь квадрата = " + s.ToString());
}
Test2();
void Test3()
{
    double p = 10.0;
    double s = ClassShapes.AreaSquare(p);
    Console.WriteLine("Площадь квадрата = " + s.ToString());
}
Test3();

//Площадь квадрата = 16
//Площадь квадрата = 0,390625
//Площадь квадрата = 6,25
//Правильные ответы: 16 0,390625 6,25

void Test4()
{
    double p = 16;
    double s = ClassShapes.HexagonSquare(p);
    Console.WriteLine("Площадь шестиугольника = " + s.ToString());
}
Test4();
void Test5()
{
    double p = 2.5;
    double s = ClassShapes.HexagonSquare(p);
    Console.WriteLine("Площадь шестиугольника = " + s.ToString());
}
Test5();
void Test6()
{
    double p = 10.0;
    double s = ClassShapes.HexagonSquare(p);
    Console.WriteLine("Площадь шестиугольника = " + s.ToString());
}
Test6();
//Площадь шестиугольника = 18,475208614068
//Площадь шестиугольника = 0,451054897804395
//Площадь шестиугольника = 7,21687836487032
//Правильные ответы: 18,475208614068 0,451054897804395 7,21687836487032

void Test7()
{
    double p = 16;
    double s = ClassShapes.CircleSquare(p);
    Console.WriteLine("Площадь круга = " + s.ToString());
}
Test7();
void Test8()
{
    double p = 2.5;
    double s = ClassShapes.CircleSquare(p);
    Console.WriteLine("Площадь круга = " + s.ToString());
}
Test8();
void Test9()
{
    double p = 10.0;
    double s = ClassShapes.CircleSquare(p);
    Console.WriteLine("Площадь круга = " + s.ToString());
}
Test9();
//Площадь круга = 20,3718327157626
//Площадь круга = 0,497359197162173
//Площадь круга = 7,95774715459477
//Правильные ответы: 20,3718327157626 0,497359197162173 7,95774715459477

void Test10()
{
    double p = 16;
    double s = ClassShapes.TriangleSquare(p);
    Console.WriteLine("Площадь треугольника = " + s.ToString());
}
Test10();
void Test11()
{
    double p = 2.5;
    double s = ClassShapes.TriangleSquare(p);
    Console.WriteLine("Площадь треугольника = " + s.ToString());
}
Test11();
void Test12()
{
    double p = 10.0;
    double s = ClassShapes.TriangleSquare(p);
    Console.WriteLine("Площадь треугольника = " + s.ToString());
}
Test12();
//Площадь треугольника = 12,316805742712
//Площадь треугольника = 0,30070326520293
//Площадь треугольника = 4,81125224324688
//Правильные ответы: 12,316805742712 0,30070326520293 4,81125224324688

void Test13()
{
    double p = 16;
    double s = ClassShapes.RombSquare(p);
    Console.WriteLine("Площадь ромба = " + s.ToString());
}
Test13();
void Test14()
{
    double p = 2.5;
    double s = ClassShapes.RombSquare(p);
    Console.WriteLine("Площадь ромба = " + s.ToString());
}
Test14();
void Test15()
{
    double p = 10.0;
    double s = ClassShapes.RombSquare(p);
    Console.WriteLine("Площадь ромба = " + s.ToString());
}
Test15();
//Площадь ромба = 13,856406460551
//Площадь ромба = 0,338291173353296
//Площадь ромба = 5,41265877365274
//Правильные ответы: 13,856406460551 0,338291173353296 5,41265877365274

void Test16()
{
    double p = 16;
    double s = ClassShapes.Square(p);
    Console.WriteLine("Площадь прямоугольника = " + s.ToString());
}
Test16();
void Test17()
{
    double p = 2.5;
    double s = ClassShapes.Square(p);
    Console.WriteLine("Площадь прямоугольника = " + s.ToString());
}
Test17();
void Test18()
{
    double p = 10.0;
    double s = ClassShapes.Square(p);
    Console.WriteLine("Площадь прямоугольника = " + s.ToString());
}
Test18();
//Площадь прямоугольника = 14,2222222222222
//Площадь прямоугольника = 0,347222222222222
//Площадь прямоугольника = 5,55555555555556
//Правильные ответы: 14,2222222222222 0,347222222222222 5,55555555555556