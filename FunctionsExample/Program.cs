namespace FunctionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            HelloWorld("Testi");

            string helloWorld = GetHelloWorld();

            List<string> strings = new List<string>() { "Hello", "World" };

            Console.WriteLine("Lista ennen lisäys funktiota");
            PrintList(strings);

            AddStringToList(strings, "Testi");
            Console.WriteLine("Lista lisäys funktion jälkeen");
            PrintList(strings); 


            List<string> returnList = CreateNewList(5);
            Console.WriteLine("Lista, jonka CreateNewList loi");
            PrintList(returnList);

            RemoveItemsFromList(returnList, 2);
            Console.WriteLine("Lista, jonka RemoveItemsFromList poisti");
        }

        /// <summary>
        /// Funktio, joka tulostaa "Hello, World!" ja jossa ei ole parametreja
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Funktio, joka tulostaa "Hello, {name}!, jossa name on parametri"
        /// </summary>
        /// <param name="name"></param>
        static void HelloWorld(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        /// <summary>
        /// Funktio, joka palauttaa merkkijonon "Hello, World!"
        /// </summary>
        /// <returns></returns>
        static string GetHelloWorld()
        {
            return "Hello, World!";
        }

        /// <summary>
        /// Lisää annetun arvon listaan, joka on annettu parametrina
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        static void AddStringToList(List<string> list, string value)
        {
            list.Add(value);
        }

        /// <summary>
        /// Funktio, joka palauttaa listan, jossa on numberOfItems määrä arvoja
        /// </summary>
        /// <param name="numberOfItems"></param>
        /// <returns></returns>
        static List<string> CreateNewList(int numberOfItems)
        {
            List<string> demoList = new List<string>();

            for (int i = 0; i < numberOfItems; i++)
            {
                demoList.Add($"Item {i}");
            }

            return new List<string>();
        }

        static void RemoveItemsFromList(List<string> list, int numberOfItemsToRemove)
        {
            for (int i = 0; i < numberOfItemsToRemove; i++)
            {
                list.RemoveAt(0);
            }
        }

        /// <summary>
        /// Funktio, joka tulostaa listan arvot
        /// </summary>
        /// <param name="list"></param>
        static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item); 
            }
        }
    }
}