using System;

namespace Task8
{
    class Invoice
    {
        public Invoice(int account, string customer, string provider)
        {
            this._account  = account;
            this._customer = customer;
            this._provider = provider;
        }
        
        public string Article { set; get; }
        public int    Quantity  { set; get; }

        public void CalculateCost(bool isVat)
        {
            double cost;
            switch (Article)
            {
                case "SSD":
                    cost = 5600;
                    break;
                case "HHD":
                    cost = 4750;
                    break;
                case "USB flash":
                    cost = 1749;
                    break;
                default:
                    cost = 0;
                    Console.WriteLine("Unknown article");
                    break;
            }

            if (isVat)
            {
                cost += (cost * 0.2);
            }

            Console.WriteLine($"Sum: {cost * Quantity}Rub");
        }

        private readonly int    _account;
        private readonly string _customer, _provider;
    }
}
