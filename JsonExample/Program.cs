namespace JsonExample
{
    internal class Program
    {
        static void Main()
        {
            JsonFileService jsonService = new();
            string filePath = "people.json";

            // Create example data
            List<Person> people = new List<Person>
            {
                new Person
                {
                    Name = "Anna Virtanen",
                    Age = 28,
                    HomeAddress = new Address { Street = "Katu 123", City = "Helsinki", PostalCode = "00100" }
                },
                new Person
                {
                    Name = "Mikko Mäkinen",
                    Age = 35,
                    HomeAddress = new Address { Street = "Tie 45", City = "Espoo", PostalCode = "02100" }
                }
            };

            // Write to JSON
            jsonService.WriteToFile(filePath, people);
            Console.WriteLine($"Data written to {filePath}\n");

            // Read from JSON
            List<Person>? loadedPeople = jsonService.ReadFromFile<List<Person>>(filePath);

            if (loadedPeople != null)
            {
                Console.WriteLine("Loaded people:");
                foreach (var p in loadedPeople)
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old, lives in {p.HomeAddress.City}");
                }
            }
        }
    }
}
