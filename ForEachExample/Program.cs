using System;
using System.Collections.Generic;

namespace ForEachExample
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== foreach Loop Examples ===\n");

            PrintAnimals();             // Example 1: iterate a string array
            PrintNumbersFiltered();     // Example 2: filter while printing
            CollectOddNumbers();        // Example 3: add odd numbers to a new list
        }

        // ------------------------------------------------------------
        // Example 1: Loop through an array of animal names
        // ------------------------------------------------------------
        static void PrintAnimals()
        {
            string[] animals = { "Dog", "Cat", "Horse", "Rabbit" };

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        // ------------------------------------------------------------
        // Example 2: Loop through a List<int> and print only numbers > 2
        // ------------------------------------------------------------
        static void PrintNumbersFiltered()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                if (number > 2)
                {
                    Console.WriteLine(number);
                }
            }
        }

        // ------------------------------------------------------------
        // Example 3: Use foreach to collect all odd numbers
        // ------------------------------------------------------------
        static void CollectOddNumbers()
        {
            // Start with a list of numbers from 1 to 10.
            List<int> allNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create an empty list to hold the odd numbers we find.
            List<int> oddNumbers = new List<int>();

            // Loop through each number in the source list.
            foreach (int number in allNumbers)
            {
                // Check if the number is odd.
                // A number is odd when dividing by 2 leaves a remainder of 1.
                if (number % 2 != 0)
                {
                    // Add the odd number to the new list.
                    oddNumbers.Add(number);
                    Console.WriteLine($"Added odd number: {number}");
                }
            }

            // Display all collected odd numbers.
            Console.WriteLine("\nOdd numbers collected:");
            foreach (int odd in oddNumbers)
            {
                Console.WriteLine(odd);
            }
        }
    }
}
