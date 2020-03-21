using System;

/*
 * Создать класс Converter.
 * В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
 * и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public
 * Converter(double usd, double eur, double rub).
 * Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
 * также программа должна производить конвертацию из указанных валют в гривну.
 */

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(0.036, 0.033, 2.79);
            converter.ToUsd(100);
            converter.ToEur(100);
            converter.ToRub(100);
            converter.FromUsd(100);
            converter.FromEur(100);
            converter.FromRub(100);

            Console.ReadKey();
        }
    }
}
