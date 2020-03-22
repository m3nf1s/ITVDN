using System;

namespace Task6
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            this._usd = usd;
            this._eur = eur;
            this._rub = rub;
        }

        private readonly double _usd, _eur, _rub;

        public void ToUsd(double usd)
        {
            Console.WriteLine("{0:F2}", usd * _usd);
        }

        public void ToEur(double eur)
        {
            Console.WriteLine("{0:F2}", eur * _eur);
        }

        public void ToRub(double rub)
        {
            Console.WriteLine("{0:F2}", rub * _rub);
        }

        public void FromUsd(double uah)
        {
            Console.WriteLine("{0:F2}", uah / _usd);
        }

        public void FromEur(double uah)
        {
            Console.WriteLine("{0:F2}", uah / _eur);
        }

        public void FromRub(double uah)
        {
            Console.WriteLine("{0:F2}", uah / _rub);
        }
    }
}