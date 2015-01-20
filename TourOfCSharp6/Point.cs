using static System.Math;

namespace TourOfCSharp6
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Sqrt(X * X + Y * Y);

        public override string ToString()
        {
            return string.Format("{{{0:F2}, {1:F2}}}, Distance = {2:F2}", X, Y, Distance);
        }
    }
}
