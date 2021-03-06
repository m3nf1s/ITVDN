﻿using System;

/*
 * Создать классы Point и Figure.
 * Класс Point должен содержать два целочисленных поля и одно строковое поле.
 * Создать три свойства с одним методом доступа get.
 * Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
 * Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
 * Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
 * void PerimeterCalculator(), который рассчитывает периметр многоугольника.
 * Написать программу, которая выводит на экран название и периметр многоугольника.
 */

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Figure(new Point(10,20,"A"),
                new Point(15,30,"B"), new Point(40,11, "C"));

            fig.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
