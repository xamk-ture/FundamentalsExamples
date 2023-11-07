namespace ContainsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void ContainsExample()
        {
            var names = new List<string>()
            {
                "John",
                "Mary",
                "Bob",
                "Alice"
            };

            if (names.Contains("Bob"))
            {
                Console.WriteLine("Bob is in the list");
            }

            if (names.Contains("Steve") == false)
            {
                Console.WriteLine("Steve is not in the list");
            }

            if(OwnCotainsMethod(names, "Bob"))
            {
                Console.WriteLine("Bob is in the list");
            }  
            
            if(OwnCotainsMethod(names, "Steve") == false)
            {
                Console.WriteLine("Steve is in the list");
            }

        }

        static bool OwnCotainsMethod(List<string> names, string nameToFind) 
        {
            bool found = false;

            foreach (string name in names)
            {
                if (name == nameToFind)
                {
                    found = true;
                    break; // Name was found so we can stop the loop
                }
            }

            return found;
        }
    }
}