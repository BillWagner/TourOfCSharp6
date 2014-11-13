using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourOfCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            var sequence = from n in Enumerable.Range(0, 100)
                           select new Point { X = random.NextDouble() * 1000, Y = random.NextDouble() * 1000 };

            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
