using System;

namespace Task3
{
    class Title
    {
        public Title(string title)
        {
            this._title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_title);
        }
        private readonly string _title;
    }
}