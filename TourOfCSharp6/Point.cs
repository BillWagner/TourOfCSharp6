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
            return string.Format("{{{0:F2}, {1:F2}}}, Distance = {2:F2}", X, Y, Distance);
        }
    }
}
