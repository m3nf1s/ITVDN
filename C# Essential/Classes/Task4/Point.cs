namespace Task4
{
    class Point
    { 
        public Point(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }

        public int X { get; }
        public int Y { get; }
        public string Name { get; }
    }
}