namespace Task1
{
    class Address
    {
        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public int House
        {
            get => _house;
            set => _house = value;
        }

        public int Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public override string ToString()
        {
            return
                $"Index: {Index}, Country: {Country}, City: {City}, Street: {Street}, House: {House}, Apartment: {Apartment}";
        }

        private int _index, _house, _apartment;
        private string _country, _city, _street;
    }
}