using System;
using static System.Console;
using System.Collections.Generic;
using static System.Linq.Enumerable;

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
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    var points = SimulatedWebRequest();
                    foreach (var item in points)
                        Console.WriteLine(item);
                }
                catch (Exception e) when (logException(e)) { }
                catch (TimeoutException e) when (failures++ < 10)
                {
                    WriteLine("Timeout error: trying again");
                }
            }
            //PartOne();
        }

        private static bool logException(Exception e)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: {0}", e);
            Console.ForegroundColor = oldColor;
            return false;
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

            foreach (var item in sequence)
                Console.WriteLine(item);
        }
    }
}
