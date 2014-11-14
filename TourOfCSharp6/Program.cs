using System;
using System.Console;
using System.Collections.Generic;
using System.Linq.Enumerable;

namespace TourOfCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var webErrors = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };

            int failures = 0;
            for (int i = 0; i < 100; i++)
            {
                try {
                    var points = SimulatedWebRequest();
                    foreach (var item in points)
                        Console.WriteLine(item);
                } catch(TimeoutException e) if (failures++ < 10)
                {
                    WriteLine("Timeout error: trying again");
                }

            }


            //PartOne();
        }

        private static IEnumerable<Point> SimulatedWebRequest()
        {
            var random = new System.Random();
            var delay = random.NextDouble() * 5000;

            var range = Range(1, 100);
            var sequence = from n in range
                           select new Point(
                               random.NextDouble() * 1000,
                               random.NextDouble() * 1000
                           );
            if (delay > 3000)
                throw new TimeoutException("This just failed");
            return sequence;
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

            // Should not compile, but does with VS2015 14.0.22310.1
            var sequence3 = Select(range, n => new Point
            (
                random.NextDouble() * 1000,
                random.NextDouble() * 1000
            ));

            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
