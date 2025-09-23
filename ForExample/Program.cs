using System;

namespace ForExample
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== For Loop Examples ===\n");

            CountFiveTimes();            // Basic counter: 0..4
            PrintArrayWithFor();         // Iterate array using for and indexes
            PrintArrayWithForeach();     // Iterate array using foreach (simpler)
            ForWithBreakAndContinue();   // Demonstrates break and continue
            ReverseLoop();               // Count backwards (useful with arrays)
        }

        // ------------------------------------------------------------
        // Example 1: Repeat a message five times using a for loop
        // ------------------------------------------------------------
        static void CountFiveTimes()
        {
            // for has three parts:
            // 1) initialization:   int i = 0     (run once)
            // 2) condition:        i < 5         (checked before each iteration)
            // 3) increment:        i++           (run after each iteration)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration number {i}");
            }
        }

        // ------------------------------------------------------------
        // Example 2: Use a for loop to print every element in an array
        // ------------------------------------------------------------
        static void PrintArrayWithFor()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            // We control the index, so we can also use i for positions, skipping, etc.
            for (int i = 0; i < fruits.Length; i++)
            {
                // Access element at position i
                Console.WriteLine($"Index {i}: {fruits[i]}");
            }
        }

        // ------------------------------------------------------------
        // Example 3: Same task using foreach (no index needed)
        // ------------------------------------------------------------
        static void PrintArrayWithForeach()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            // foreach walks through all items; simpler when you don't need the index
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        // ------------------------------------------------------------
        // Example 4: Using break and continue in a for loop
        // ------------------------------------------------------------
        static void ForWithBreakAndContinue()
        {
            // We'll loop 0..9 and:
            // - skip printing when i is 3 (continue)
            // - stop the loop entirely when i reaches 7 (break)
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    // Skip the rest of this iteration and move to i = 4
                    continue;
                }

                if (i == 7)
                {
                    // Stop the loop completely
                    break;
                }

                Console.WriteLine($"i = {i}");
            }

            // Output: 0, 1, 2, 4, 5, 6
        }

        // ------------------------------------------------------------
        // Example 5: Count backwards (useful when removing items by index)
        // ------------------------------------------------------------
        static void ReverseLoop()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            // Start from the last valid index (Length - 1) and go down to 0
            for (int i = fruits.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Reverse index {i}: {fruits[i]}");
            }
        }
    }
}
