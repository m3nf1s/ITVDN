using System;

namespace Task3
{
    class Author
    {
        public Author(string author)
        {
            this._author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_author);
        }

        private readonly string _author;
    }
}