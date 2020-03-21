using System;

/*
 * Создать класс Book. Создать классы Title, Author и Content,
 * каждый из которых должен содержать одно строковое поле и метод void Show().
 * Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
 * Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
 */

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Author("Shia LaBeouf"), new Title("Just do it"), new Content("This book about Just do it"));
            book.Show();
            Console.ReadKey();
        }
    }
}
