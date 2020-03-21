using System;

namespace Task3
{
    class Content
    {
        public Content(string content)
        {
            this._content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_content);
        }

        private readonly string _content;
    }
}