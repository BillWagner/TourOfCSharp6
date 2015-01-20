using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

namespace TourOfCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var webErrors = new Dictionary<int, string>();
            webErrors.Add(404, "Page not Found");
            webErrors[302] = "Page moved, but left a forwarding address.";
            webErrors[500] = "The web server can't come out to play today.";


            //PartOne();
        }

        private static void PartOne()
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
