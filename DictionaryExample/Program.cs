using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Dictionary CRUD Examples ===\n");

            // Create an empty dictionary for fruit descriptions.
            Dictionary<string, string> fruitDict = new();

            // --- Demonstrations ---
            AddEntry(fruitDict, "Apple", "A fruit that is usually red or green.");
            AddEntry(fruitDict, "Banana", "A long and yellow fruit.");
            AddEntry(fruitDict, "Orange", "A round, orange-colored citrus fruit.");

            PrintAll(fruitDict);

            FetchValue(fruitDict, "Banana");
            FetchValue(fruitDict, "Pear");          // key not present

            UpdateEntry(fruitDict, "Banana", "Sweet yellow fruit, rich in potassium.");
            RemoveEntry(fruitDict, "Orange");
            PrintKeys(fruitDict);
            PrintValues(fruitDict);
            PrintAll(fruitDict);
        }

        // ---------- Core Operations ----------

        /// <summary>Adds a new key/value pair if the key does not exist.</summary>
        static void AddEntry(Dictionary<string, string> dict, string key, string value)
        {
            if (dict.TryAdd(key, value))
            {
                Console.WriteLine($"Added: {key} -> {value}");
            }
            else
            {
                Console.WriteLine($"Key \"{key}\" already exists. No change made.");
            }
        }

        /// <summary>Removes an entry if the key exists.</summary>
        static void RemoveEntry(Dictionary<string, string> dict, string key)
        {
            if (dict.Remove(key))
            {
                Console.WriteLine($"Removed key \"{key}\".");
            }
            else
            {
                Console.WriteLine($"Cannot remove: key \"{key}\" was not found.");
            }
        }

        /// <summary>Updates the value for a given key, or reports if key is missing.</summary>
        static void UpdateEntry(Dictionary<string, string> dict, string key, string newValue)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = newValue;
                Console.WriteLine($"Updated \"{key}\" to -> {newValue}");
            }
            else
            {
                Console.WriteLine($"Cannot update: key \"{key}\" not found.");
            }
        }

        /// <summary>Fetches and prints the value for a key if it exists.</summary>
        static void FetchValue(Dictionary<string, string> dict, string key)
        {
            if (dict.TryGetValue(key, out string value))
            {
                Console.WriteLine($"Fetched: {key} -> {value}");
            }
            else
            {
                Console.WriteLine($"Key \"{key}\" not found.");
            }
        }

        // ---------- Listing Helpers ----------

        /// <summary>Prints all keys.</summary>
        static void PrintKeys(Dictionary<string, string> dict)
        {
            Console.WriteLine("\n-- Keys --");
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key);
            }
        }

        /// <summary>Prints all values.</summary>
        static void PrintValues(Dictionary<string, string> dict)
        {
            Console.WriteLine("\n-- Values --");
            foreach (var value in dict.Values)
            {
                Console.WriteLine(value);
            }
        }

        /// <summary>Prints all key/value pairs.</summary>
        static void PrintAll(Dictionary<string, string> dict)
        {
            Console.WriteLine("\n-- All Entries --");
            foreach (KeyValuePair<string, string> kv in dict)
            {
                Console.WriteLine($"Key: {kv.Key} | Value: {kv.Value}");
            }
        }
    }
}
