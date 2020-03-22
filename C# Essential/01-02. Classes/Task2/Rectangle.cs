namespace Task2
{
    class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Side1 { get; }

        public double Side2 { get; }

        public double AreaCalculator() => Side1 * Side2;

        public double PerimeterCalculator() => 2 * (Side1 + Side2);
    }
}