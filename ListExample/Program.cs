using System;                 // Gives access to basic .NET classes like Console
using System.Collections.Generic; // Lets us use generic collections such as List<T>

namespace ListExample          // A namespace is like a folder for your code
{
    internal class Program     // Program class holds all our methods
    {
        static void Main()     // The Main method is where the program starts running
        {
            // Allow the console to show special characters like € if needed
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== List<int> CRUD Examples ===\n");

            // Create a new empty list that can hold integers (whole numbers)
            List<int> numbers = new();

            // ---- Demonstrations of different operations ----
            AddNumbers(numbers, 1, 2, 3);     // Add three numbers to the list
            PrintAll(numbers);                // Show all numbers

            FetchByIndex(numbers, 2);         // Get the number at index 2 (3rd place)

            RemoveAtIndex(numbers, 0);        // Remove the first number (index 0)
            PrintAll(numbers);                // Show list after removal

            RemoveByValue(numbers, 2);        // Remove the number 2 if it exists
            PrintAll(numbers);                // Show final list

            DemoInlineInitialization();       // Show an alternative way to create a list
        }

        // ------------------------------------------------------------
        // Adds one or more numbers to the given list
        // ------------------------------------------------------------
        static void AddNumbers(List<int> list, params int[] values)
        {
            // 'values' acts like an int[] array inside this method.
            // You can pass any amount of integers (even zero) without creating an array yourself.
        
            foreach (int value in values)        // Loop through each number given
            {
                list.Add(value);                 // Append it to the list
                Console.WriteLine($"Added: {value}"); // Confirm to the console
            }
        }

        // Adds an array of numbers to the given list
        static void AddNumbersFromArray(List<int> list, int[] values)
        {
            // Here you must pass an actual int[] array when calling the method.
        
            foreach (int value in values)
            {
                list.Add(value);
                Console.WriteLine($"Added: {value}");
            }
        }

        // ------------------------------------------------------------
        // Prints all numbers currently in the list
        // ------------------------------------------------------------
        static void PrintAll(List<int> list)
        {
            Console.WriteLine("\n-- Current List --");
            // Loop through each number in the list and print it
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }

        // ------------------------------------------------------------
        // Gets a number from the list by its position (index)
        // ------------------------------------------------------------
        static void FetchByIndex(List<int> list, int index)
        {
            // Check that the index is valid (0 to Count-1)
            if (index >= 0 && index < list.Count)
            {
                // Access the value directly using the indexer [index]
                int value = list[index];
                Console.WriteLine($"\nValue at index {index}: {value}");
            }
            else
            {
                Console.WriteLine($"\nIndex {index} is out of range.");
            }
        }

        // ------------------------------------------------------------
        // Removes an item at a specific position in the list
        // ------------------------------------------------------------
        static void RemoveAtIndex(List<int> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                // Show which value is being removed
                Console.WriteLine($"\nRemoving value at index {index} ({list[index]})");
                // Remove the item at the given index
                list.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"\nCannot remove: index {index} is out of range.");
            }
        }

        // ------------------------------------------------------------
        // Removes the first matching value from the list
        // ------------------------------------------------------------
        static void RemoveByValue(List<int> list, int value)
        {
            Console.WriteLine($"\nAttempting to remove value {value}");
            // List.Remove returns true if it found and removed the value
            if (list.Remove(value))
            {
                Console.WriteLine($"Removed value {value}");
            }
            else
            {
                Console.WriteLine($"Value {value} not found, nothing removed.");
            }
        }

        // ------------------------------------------------------------
        // Shows another way to create and fill a list in one step
        // ------------------------------------------------------------
        static void DemoInlineInitialization()
        {
            Console.WriteLine("\n-- Inline Initialization Demo --");
            // Create a list and immediately fill it with values 1, 2, and 3
            List<int> numbers2 = new List<int> { 1, 2, 3 };

            // Print each number to show the list contents
            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
