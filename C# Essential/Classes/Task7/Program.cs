using System;

/*
 * Создать класс Employee.
 * В теле класса создать пользовательский конструктор, который принимает два строковых аргумента,
 * и инициализирует поля, соответствующие фамилии и имени сотрудника.
 * Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
 * Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.
 */

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Alex", "Warvine")
            {
                Age = 20,
                Post = "Developer",
                Experience = 1,

            };

            Employee employee = new Employee("Jack", "Vardebn")
            {
                Age = -20,
                Experience = -10,

            };

            Console.WriteLine(emp.ToString());
            Console.WriteLine(employee.ToString());

            Console.ReadKey();
        }
    }
}
