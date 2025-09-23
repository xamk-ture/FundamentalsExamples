using System;
using System.Collections.Generic;

namespace FunctionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Functions & Parameters (value, out, ref) ===\n");

            // --------------------------------------------------------------------
            // 1) Basic functions (no parameters / with parameters / return value)
            // --------------------------------------------------------------------
            HelloWorld();                       // prints: Hello, World!
            HelloWorld("Tester");               // prints: Hello, Tester!
            string msg = GetHelloWorld();       // returns "Hello, World!"
            Console.WriteLine($"GetHelloWorld() returned: {msg}");

            // --------------------------------------------------------------------
            // 2) Working with a List<string>
            // --------------------------------------------------------------------
            List<string> words = new List<string> { "Hello", "World" };

            Console.WriteLine("\nList before AddStringToList:");
            PrintList(words);

            AddStringToList(words, "Demo");     // appends "Demo" to list

            Console.WriteLine("\nList after AddStringToList:");
            PrintList(words);

            List<string> generated = CreateNewList(5);  // creates: Item 0..Item 4
            Console.WriteLine("\nList created by CreateNewList(5):");
            PrintList(generated);

            // Remove first N items safely (won't crash if N > Count)
            RemoveItemsFromList(generated, 2);
            Console.WriteLine("\nList after RemoveItemsFromList(..., 2):");
            PrintList(generated);

            // --------------------------------------------------------------------
            // 3) out parameter examples (produce extra data back to the caller)
            // --------------------------------------------------------------------
            Console.WriteLine("\n--- out examples ---");

            // 3a) TryFindIndex: try to find the index of a value in the list
            if (TryFindIndex(words, "World", out int foundIndex))
            {
                Console.WriteLine($"Found \"World\" at index {foundIndex}");
            }
            else
            {
                Console.WriteLine("Value \"World\" not found");
            }

            // 3b) TryParseInt: safe parsing with out
            string userInput = "123";
            if (TryParseInt(userInput, out int parsed))
            {
                Console.WriteLine($"Parsed \"{userInput}\" into integer {parsed}");
            }
            else
            {
                Console.WriteLine($"\"{userInput}\" is not a valid integer");
            }

            // 3c) CalculateStats: return min, max, average via out
            if (CalculateStats(new List<int> { 4, 2, 8, 6 }, out int min, out int max, out double avg))
            {
                Console.WriteLine($"Stats -> min:{min} max:{max} avg:{avg}");
            }

            // --------------------------------------------------------------------
            // 4) ref parameter examples (modify the caller's variable *in place*)
            // --------------------------------------------------------------------
            Console.WriteLine("\n--- ref examples ---");

            // 4a) Increment(ref int) mutates the same variable
            int counter = 10;
            Console.WriteLine($"counter before Increment: {counter}");
            Increment(ref counter); // counter becomes 11
            Console.WriteLine($"counter after  Increment: {counter}");

            // 4b) Swap(ref a, ref b) swaps values without a temp in the caller
            int a = 1, b = 2;
            Console.WriteLine($"Before Swap: a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After  Swap: a={a}, b={b}");

            // 4c) ReplaceListWithDefaults(ref list) reassigns the *variable* itself
            Console.WriteLine("\nOriginal 'words' list:");
            PrintList(words);

            ReplaceListWithDefaults(ref words); // caller's 'words' now points to a brand-new list
            Console.WriteLine("\n'words' after ReplaceListWithDefaults(ref words):");
            PrintList(words);

            // 4d) AppendSuffixInPlace(ref string) changes the same string variable
            string title = "Report";
            Console.WriteLine($"\nBefore AppendSuffixInPlace: {title}");
            AppendSuffixInPlace(ref title, " (v1)");
            Console.WriteLine($"After  AppendSuffixInPlace: {title}");

            Console.WriteLine("\nDone. Press Enter to exit.");
            Console.ReadLine();
        }

        // =========================================================================
        // BASIC FUNCTIONS
        // =========================================================================

        /// <summary>
        /// Prints "Hello, World!" to the console. No parameters, no return value.
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Prints "Hello, {name}!" where 'name' is provided by the caller.
        /// </summary>
        static void HelloWorld(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        /// <summary>
        /// Returns the string "Hello, World!" without printing it.
        /// </summary>
        static string GetHelloWorld()
        {
            return "Hello, World!";
        }

        // =========================================================================
        // LIST HELPERS
        // =========================================================================

        /// <summary>
        /// Adds 'value' to the end of 'list'.
        /// </summary>
        static void AddStringToList(List<string> list, string value)
        {
            list.Add(value);
        }

        /// <summary>
        /// Creates and returns a new list that contains "Item 0", "Item 1", ... up to count-1.
        /// </summary>
        static List<string> CreateNewList(int count)
        {
            var result = new List<string>();
            for (int i = 0; i < count; i++)
            {
                result.Add($"Item {i}");
            }
            return result;
        }

        /// <summary>
        /// Removes the first 'numberOfItemsToRemove' items safely (does nothing if the list is smaller).
        /// </summary>
        static void RemoveItemsFromList(List<string> list, int numberOfItemsToRemove)
        {
            // Remove at most 'list.Count' items to avoid ArgumentOutOfRangeException
            int removeCount = Math.Min(list.Count, Math.Max(0, numberOfItemsToRemove));
            for (int i = 0; i < removeCount; i++)
            {
                list.RemoveAt(0);
            }
        }

        /// <summary>
        /// Prints each item on its own line. If list is empty, prints "(empty)".
        /// </summary>
        static void PrintList(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("(empty)");
                return;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // =========================================================================
        // OUT EXAMPLES
        // =========================================================================

        /// <summary>
        /// Tries to find 'value' in 'list'. Returns true if found and sets 'index' via out.
        /// If not found, returns false and sets 'index' to -1.
        /// </summary>
        static bool TryFindIndex(List<string> list, string value, out int index)
        {
            // Initialize out parameter with a default
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                // Use OrdinalIgnoreCase for simple case-insensitive comparison
                if (string.Equals(list[i], value, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;      // assign the found position to the out variable
                    return true;    // indicate success
                }
            }

            return false;           // not found; 'index' remains -1
        }

        /// <summary>
        /// Safe integer parsing example using out. Returns true if parse succeeds.
        /// </summary>
        static bool TryParseInt(string text, out int value)
        {
            // Delegate to the BCL TryParse, which itself uses an 'out' parameter.
            return int.TryParse(text, out value);
        }

        /// <summary>
        /// Calculates min, max, and average (no LINQ). Returns false for empty input.
        /// Outputs are provided via 'out' parameters.
        /// </summary>
        static bool CalculateStats(List<int> numbers, out int min, out int max, out double average)
        {
            min = 0;
            max = 0;
            average = 0;

            if (numbers == null || numbers.Count == 0)
                return false;

            long sum = 0;                // long to be safe with many values
            min = numbers[0];
            max = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                int n = numbers[i];
                if (n < min) min = n;
                if (n > max) max = n;
                sum += n;
            }

            average = sum / (double)numbers.Count;
            return true;
        }

        // =========================================================================
        // REF EXAMPLES
        // =========================================================================

        /// <summary>
        /// Increments the same 'number' variable in the caller (ref passes a reference).
        /// </summary>
        static void Increment(ref int number)
        {
            number++; // modifies the caller's variable directly
        }

        /// <summary>
        /// Swaps the values of 'a' and 'b' in the caller using ref parameters.
        /// </summary>
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Replaces the caller's list variable with a brand-new default list.
        /// Demonstrates that 'ref' lets a method reassign the *variable itself*.
        /// </summary>
        static void ReplaceListWithDefaults(ref List<string> list)
        {
            list = new List<string> { "Default 1", "Default 2", "Default 3" };
        }

        /// <summary>
        /// Appends a suffix to the same string variable in the caller.
        /// (Strings are immutable; without 'ref' we would only change a local copy.)
        /// </summary>
        static void AppendSuffixInPlace(ref string text, string suffix)
        {
            text = (text ?? string.Empty) + (suffix ?? string.Empty);
        }
    }
}
