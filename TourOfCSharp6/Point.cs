using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourOfCSharp6
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);
    }
}
