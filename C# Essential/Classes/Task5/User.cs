using System;

namespace Task5
{
    class User
    {
        public User(string login, string name, string surname, int age)
        {
            this.Login   = login;
            this.Name    = name;
            this.Surname = surname;
            this.Age     = age;
            this.Time    = DateTime.Now;
        }

        public string Login   { set; get; }
        public string Name    { set; get; }
        public string Surname { set; get; }
        public int Age
        {
            set
            {
                if (value > 0)
                {
                    _age = value;
                }

            }
            get => _age;
        }

        public DateTime Time { get; }

        private int _age;
        
        public override string ToString()
        {
            return $"Login: {Login}, Name: {Name}, Surname: {Surname}, Age: {Age}, Time: {Time}";
        }
    }
}
