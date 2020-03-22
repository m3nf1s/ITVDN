using System;

namespace Task4
{
    class Figure
    {
        public Figure(params Point[] points)
        {
            this._points = points;
        }

        public void PerimeterCalculator()
        {
            Console.WriteLine("Figure has: ");
            
            double perimeter = 0;
            for (int i = 0; i < _points.Length; ++i)
            {
                Console.WriteLine($"Point {_points[i].Name} with coordinates: {_points[i].X} and {_points[i].Y}");   
                
                if (i != _points.Length - 1)
                {
                    perimeter += LengthSide(_points[i], _points[i + 1]);
                }
                else
                {
                    perimeter += LengthSide(_points[i], _points[0]);
                }
            }

            Console.WriteLine($"and perimeter: {perimeter:F1}");
        }
        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        private readonly Point[] _points;
    }
}
