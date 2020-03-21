namespace Task7
{
    class Employee
    {
        public Employee(string name, string surname)
        {
            this.Name    = name;
            this.Surname = surname;
        }

        public string Name    { get; }
        public string Surname { get; }

        public int Age
        {
            set { _age = value > 18 ? value : Error; }
            get { return _age != Error ? _age : Error; }
        }

        public string Post
        {
            set
            {
                if (value != null)
                {
                    _post = value;
                }
            }
            get { return _post != null ? _post : "Post unknown"; }
        }

        public int Experience
        {
            set { _experience = value >= 0 ? value : Error; }
            get { return _experience != Error ? _experience : Error; }
        }

        public double CountSalary()
        {
            double salarycoef;

            switch (Post.ToLower())
            {
                case "manager":
                    salarycoef = 200;
                    break;
                case "developer":
                    salarycoef = 150;
                    break;
                case "secretary":
                    salarycoef = 80;
                    break;
                case "cleaner":
                    salarycoef = 65;
                    break;
                default:
                    salarycoef = 100;
                    break;
            }

            switch (Experience)
            {
                case 0:
                    salarycoef *= 1.5;
                    break;
                case 1:
                    salarycoef *= 2;
                    break;
                case 2:
                    salarycoef *= 2.5;
                    break;
                case -1:
                    salarycoef *= -1;
                    break;
                default:
                    salarycoef *= 5;
                    break;
            }
            return salarycoef;
        }

        public override string ToString()
        {
            return $"Surname: {Surname}, Name {Name}, Age: {Age}, Post: {Post}, Salary: {CountSalary()}";
        }

        private int       _age, _experience;
        private string    _post;
        private const int Error = -1;
    }
}
