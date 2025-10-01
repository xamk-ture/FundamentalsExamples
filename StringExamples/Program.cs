using System;
using System.Collections.Generic;

namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }

        /// <summary>
        /// Main loop that shows a menu and executes the chosen example.
        /// </summary>
        private static void RunMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Map menu options to example actions
            Dictionary<int, Action> actions = new Dictionary<int, Action>
            {
                { 1, LengthExample },
                { 2, IndexingExample },
                { 3, ContainsExample },
                { 4, StartsEndsWithExample },
                { 5, IndexOfExample },
                { 6, SplitExample },
                { 7, JoinExample },
                { 8, SubstringExample },
                { 9, ReplaceExample },
                { 10, ToUpperLowerExample },
                { 11, TrimExample },
                { 12, EqualsExample },
                { 13, CompareExample },
                { 14, InterpolationExample },
                { 15, NullOrEmptyExample },
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== String Examples (C#) ===\n");
                Console.WriteLine("Choose an example to run:");
                Console.WriteLine("  1) Length");
                Console.WriteLine("  2) Indexing (char by index)");
                Console.WriteLine("  3) Contains");
                Console.WriteLine("  4) StartsWith / EndsWith");
                Console.WriteLine("  5) IndexOf / LastIndexOf");
                Console.WriteLine("  6) Split");
                Console.WriteLine("  7) Join");
                Console.WriteLine("  8) Substring");
                Console.WriteLine("  9) Replace");
                Console.WriteLine(" 10) ToUpper / ToLower");
                Console.WriteLine(" 11) Trim / TrimStart / TrimEnd");
                Console.WriteLine(" 12) Equals (with StringComparison)");
                Console.WriteLine(" 13) Compare (lexicographical order)");
                Console.WriteLine(" 14) String interpolation ($)");
                Console.WriteLine(" 15) IsNullOrEmpty / IsNullOrWhiteSpace");
                Console.WriteLine("  0) Exit");
                Console.Write("\nEnter a number: ");

                int choice = ReadInt("number between 0-15");
                if (choice == 0) break;

                if (actions.TryGetValue(choice, out var action))
                {
                    Console.Clear();
                    action.Invoke();
                }
                else
                {
                    Console.WriteLine("Unknown option. Please try again.");
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey(true);
            }

            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Reads and validates an integer from the console.
        /// Shows the given hint in the prompt to guide the user.
        /// </summary>
        private static int ReadInt(string hint)
        {
            while (true)
            {
                Console.Write($"({hint}) > ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                    return value;

                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        // ===========================
        // Examples (each in its own function)
        // ===========================

        // Example 1: Length of a string
        static void LengthExample()
        {
            string text = "Hello";
            // Length returns the number of UTF-16 code units (commonly the number of characters for BMP)
            Console.WriteLine($"LengthExample: \"{text}\" has length {text.Length}");
        }

        // Example 2: Indexing characters in a string
        static void IndexingExample()
        {
            string word = "Hello";
            // Indexing returns the char at a given zero-based index
            char first = word[0];
            Console.WriteLine($"IndexingExample: The first character of \"{word}\" is '{first}'");
        }

        // Example 3: Contains (case-sensitive by default, culture-sensitive overloads exist)
        static void ContainsExample()
        {
            string phrase = "hello world";
            Console.WriteLine($"ContainsExample: Does \"{phrase}\" contain \"world\"? {phrase.Contains("world")}");
        }

        // Example 4: StartsWith and EndsWith
        static void StartsEndsWithExample()
        {
            string word = "hello";
            Console.WriteLine($"StartsEndsWithExample: \"{word}\" starts with \"he\"? {word.StartsWith("he")}");
            Console.WriteLine($"StartsEndsWithExample: \"{word}\" ends with \"lo\"? {word.EndsWith("lo")}");
        }

        // Example 5: IndexOf and LastIndexOf
        static void IndexOfExample()
        {
            string fruit = "banana";
            // IndexOf returns the first index of a substring, -1 if not found
            Console.WriteLine($"IndexOfExample: First \"na\" in \"{fruit}\" is at index {fruit.IndexOf("na")}");
            // LastIndexOf returns the last index of a substring
            Console.WriteLine($"IndexOfExample: Last \"na\" in \"{fruit}\" is at index {fruit.LastIndexOf("na")}");
        }

        // Example 6: Split
        static void SplitExample()
        {
            string csv = "a,b,c";
            // Split splits a string by a separator into an array
            string[] parts = csv.Split(',');
            Console.WriteLine("SplitExample: Splitting \"a,b,c\" gives:");
            foreach (string part in parts)
            {
                Console.WriteLine($"- {part}");
            }
        }

        // Example 7: Join
        static void JoinExample()
        {
            string[] items = { "a", "b", "c" };
            // Join concatenates array items using a separator
            string joined = string.Join(";", items);
            Console.WriteLine($"JoinExample: Joining [a, b, c] with ';' gives \"{joined}\"");
        }

        // Example 8: Substring
        static void SubstringExample()
        {
            string text = "HelloWorld";
            // Substring(startIndex) takes characters from startIndex to the end
            string sub = text.Substring(5);
            // Substring(startIndex, length) takes a specific length
            string sub2 = text.Substring(0, 5);
            Console.WriteLine($"SubstringExample: From index 5 -> \"{sub}\"");
            Console.WriteLine($"SubstringExample: First 5 chars -> \"{sub2}\"");
        }

        // Example 9: Replace
        static void ReplaceExample()
        {
            string text = "car red";
            // Replace substitutes all occurrences of oldValue with newValue
            string result = text.Replace("red", "blue");
            Console.WriteLine($"ReplaceExample: Replacing in \"{text}\" gives \"{result}\"");
        }

        // Example 10: ToUpper and ToLower
        static void ToUpperLowerExample()
        {
            string word = "Hello";
            // Case conversions use current culture by default; Ordinal rules are available via Compare/Equals overloads
            Console.WriteLine($"ToUpperLowerExample: \"{word}\" to upper is \"{word.ToUpper()}\"");
            Console.WriteLine($"ToUpperLowerExample: \"{word}\" to lower is \"{word.ToLower()}\"");
        }

        // Example 11: Trim / TrimStart / TrimEnd
        static void TrimExample()
        {
            string messy = "   test   ";
            // Trim removes leading and trailing whitespace
            Console.WriteLine($"TrimExample: \"{messy}\" trimmed is \"{messy.Trim()}\"");
            Console.WriteLine($"TrimExample: TrimStart -> \"{messy.TrimStart()}\"");
            Console.WriteLine($"TrimExample: TrimEnd   -> \"{messy.TrimEnd()}\"");
        }

        // Example 12: Equals with StringComparison
        static void EqualsExample()
        {
            string a = "Hello";
            string b = "hello";
            // Use StringComparison to control case and culture behavior
            bool eqOrdinalIgnoreCase = a.Equals(b, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"EqualsExample: \"{a}\" equals \"{b}\" (OrdinalIgnoreCase)? {eqOrdinalIgnoreCase}");
        }

        // Example 13: Compare (lexicographical ordering)
        static void CompareExample()
        {
            string a = "apple";
            string b = "banana";
            // Compare returns <0, 0, >0 depending on ordering
            int cmp = string.Compare(a, b, StringComparison.Ordinal); // Ordinal for byte-wise ordering
            Console.WriteLine($"CompareExample: Comparing \"{a}\" and \"{b}\" (Ordinal) returns {cmp}");
        }

        // Example 14: String interpolation
        static void InterpolationExample()
        {
            string name = "Ada";
            // Interpolation inserts variable values into the string with {$"..."}
            Console.WriteLine($"InterpolationExample: Hello, {name}!");
        }

        // Example 15: Null or Empty / Null or WhiteSpace checks
        static void NullOrEmptyExample()
        {
            string empty = "";
            string whitespace = "   ";
            // Use these helpers to robustly check for empty or whitespace-only strings
            Console.WriteLine($"NullOrEmptyExample: string.IsNullOrEmpty(\"\")? {string.IsNullOrEmpty(empty)}");
            Console.WriteLine($"NullOrEmptyExample: string.IsNullOrWhiteSpace(\"   \")? {string.IsNullOrWhiteSpace(whitespace)}");
        }
    }
}
