using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JsonExample
{
    /// <summary>
    /// This class handles saving (writing) and loading (reading) data as JSON files.
    /// It works with any type of object, such as a Person, List<Person>, etc.
    /// </summary>
    public class JsonFileService
    {
        // These options tell the serializer how to format the JSON text
        private readonly JsonSerializerOptions _options;

        /// <summary>
        /// Constructor: sets up serializer options.
        /// </summary>
        public JsonFileService()
        {
            _options = new JsonSerializerOptions
            {
                // WriteIndented = true means the JSON will be "pretty printed" (easy to read)
                WriteIndented = true
            };
        }

        /// <summary>
        /// Writes (saves) the given data to a JSON file.
        /// </summary>
        /// <typeparam name="T">The type of data you want to save (e.g., Person or List&lt;Person&gt;)</typeparam>
        /// <param name="filePath">The name or path of the file to create or overwrite.</param>
        /// <param name="data">The data to save.</param>
        public void WriteToFile<T>(string filePath, T data)
        {
            // Convert (serialize) the object into a JSON text string
            string jsonString = JsonSerializer.Serialize(data, _options);

            // Save the JSON text into a file
            File.WriteAllText(filePath, jsonString);

            // You could also add Console.WriteLine here to confirm saving
            // Console.WriteLine($"Data written to {filePath}");
        }

        /// <summary>
        /// Reads (loads) data from a JSON file and converts it back into an object.
        /// </summary>
        /// <typeparam name="T">The type of object to read (e.g., Person or List&lt;Person&gt;)</typeparam>
        /// <param name="filePath">The file path to read from.</param>
        /// <returns>The object loaded from JSON, or default (null) if file not found.</returns>
        public T? ReadFromFile<T>(string filePath)
        {
            // Check if the file exists first to prevent errors
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File '{filePath}' not found.");
                return default; // Return null (for reference types)
            }

            // Read the whole file content as text
            string jsonString = File.ReadAllText(filePath);

            // Convert (deserialize) JSON text back into an object of type T
            return JsonSerializer.Deserialize<T>(jsonString, _options);
        }
    }
}
