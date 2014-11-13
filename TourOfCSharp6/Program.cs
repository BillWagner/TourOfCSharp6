using System;
using System.Linq.Enumerable;

namespace TourOfCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            var range = Range(1, 100);
            var sequence = from n in range
                           select new Point
                           {
                               X = random.NextDouble() * 1000,
                               Y = random.NextDouble() * 1000
                           };

            var sequence2 = range
                .Select(n => new Point
                {
                    X = random.NextDouble() * 1000,
                    Y = random.NextDouble() * 1000
                });

            // Should not compile, but does with VS2015 14.0.22310.1
            var sequence3 = Select(range, n => new Point
            {
                X = random.NextDouble() * 1000,
                Y = random.NextDouble() * 1000
            });

            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
