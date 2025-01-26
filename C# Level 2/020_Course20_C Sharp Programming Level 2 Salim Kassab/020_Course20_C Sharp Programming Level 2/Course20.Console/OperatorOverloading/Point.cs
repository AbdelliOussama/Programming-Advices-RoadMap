namespace Course20.Console.OperatorOverloading_006
{
    internal class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator -(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);
        public static bool operator ==(Point p1, Point p2) => p1.X == p2.X && p1.Y == p1.Y;
        public static bool operator !=(Point p1, Point p2) => p1.X != p2.X && p1.Y != p1.Y;
        public override string ToString() => $"{X} {Y}";
    }
}