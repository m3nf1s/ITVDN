namespace Task3
{
    class Book
    {
        public Book(Author author, Title title, Content content)
        {
            this._author = author;
            this._title = title;
            this._content = content;
        }

        public void Show()
        {
            _author.Show();
            _title.Show();
            _content.Show();
        }

        private readonly Author _author;
        private readonly Title _title;
        private readonly Content _content;
    }
}