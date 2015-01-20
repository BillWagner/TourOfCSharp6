using System;
using static System.Linq.Enumerable;

namespace TourOfCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            var range = Range(1, 100);
            var sequence = from n in range
                           select new Point(
                               random.NextDouble() * 1000,
                               random.NextDouble() * 1000
                           );

            var sequence2 = range
                .Select(n => new Point
                (
                    random.NextDouble() * 1000,
                    random.NextDouble() * 1000
                ));

            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
