using System;

/*
 * Требуется: Создать класс с именем Rectangle.
 * В теле класса создать два поля, описывающие длины сторон double side1, side2.
 * Создать пользовательский конструктор Rectangle(double side1, double side2),
 * в теле которого поля side1 и side2 инициализируются значениями аргументов.
 * Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator()
 * и периметр прямоугольника - double PerimeterCalculator().
 * Создать два свойства double Area и double Perimeter с одним методом доступа get.
 * Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
 */

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(12.0, 15.0);
            Console.WriteLine("Rectangle with {0} and {1} has Perimeter {2:F1} and Area {3:F1}", 
                rec.Side1, rec.Side2, rec.PerimeterCalculator(), rec.AreaCalculator());

            Console.ReadKey();
        }
    }
}