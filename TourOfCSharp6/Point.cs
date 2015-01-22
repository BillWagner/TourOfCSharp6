using static System.Math;

namespace TourOfCSharp6
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; }
        public double Y { get; }
        public double Distance => Sqrt(X * X + Y * Y);

        public override string ToString()
        {
            return $"{{{X :F2}, {Y :F2}}}, Distance = {Distance :F2}";
        }
    }
}
