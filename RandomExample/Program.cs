using System;
using System.Collections.Generic;

namespace RandomExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Random Number Examples ===\n");

            // --------------------------------------------------------------------
            // 1) Basic random integer (0..999)
            // --------------------------------------------------------------------
            Random rng = new Random();              // create a single Random instance
            int randomNumber = rng.Next(1000);      // value between 0 and 999 inclusive
            Console.WriteLine($"Random 0–999: {randomNumber}");

            // --------------------------------------------------------------------
            // 2) Random integer within a custom range (inclusive lower, exclusive upper)
            // --------------------------------------------------------------------
            int from = 1;
            int toExclusive = 7;                    // upper bound is *exclusive*
            int diceRoll = rng.Next(from, toExclusive); // -> 1 to 6
            Console.WriteLine($"Dice roll (1–6): {diceRoll}");

            // --------------------------------------------------------------------
            // 3) Random floating-point number between 0.0 and 1.0
            // --------------------------------------------------------------------
            double between0And1 = rng.NextDouble(); // e.g. 0.7423...
            Console.WriteLine($"Random double [0.0,1.0): {between0And1}");

            // --------------------------------------------------------------------
            // 4) Generate multiple random numbers into a List<int>
            // --------------------------------------------------------------------
            List<int> numbers = CreateRandomList(rng, count: 5, min: 10, max: 20);
            Console.WriteLine("\nFive random numbers between 10 and 19:");
            foreach (int n in numbers)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            // --------------------------------------------------------------------
            // 5) Reseeding tip
            // --------------------------------------------------------------------
            // If you create many Random objects *quickly*, they may share the same seed
            // (default seed is based on current time) and produce the same sequence.
            // => Reuse a single Random instance (as we did) or provide your own seed:
            //    var rng = new Random(seedValue);
        }
    }
}
