using System;

/*
 * Создать класс с именем Address.
 * В теле класса требуется создать поля: index, country, city, street, house, apartment.
 * Для каждого поля, создать свойство с двумя методами доступа.
 * Создать экземпляр класса Address.
 * В поля экземпляра записать информацию о почтовом адресе.
 * Выведите на экран значения полей, описывающих адрес.
 */

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                Index = 120304,
                Country = "Russia",
                City = "Moscow",
                Street = "Lenina",
                House = 16,
                Apartment = 74,
            };

            Console.WriteLine(address.ToString());

            Console.ReadKey();
        }
    }
}