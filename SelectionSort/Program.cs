namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] unsortedInts = { 5, 2, 3, 1, 4 };

            foreach (var item in unsortedInts)
            {
                Console.WriteLine(item);
            }

            var sortedInts = SelectionSort(unsortedInts);

            foreach (var item in sortedInts)
            {
                Console.WriteLine(item);
            }

            var dictionary = new Dictionary<string, double>
            {
                { "Player 1", 1230 },
                { "Player 2", 456 },
                { "Player 3", 289 },
                { "Player 4", 3 }
            };

            var sortedDictionary = SelectionSortByValue(dictionary);

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static int[] SelectionSort(int[] data)
        {
            // Käy läpi koko taulukko
            for (int i = 0; i < data.Length - 1; i++)
            {
                int minIndex = i;

                // Etsi pienin alkio nykyisen alkion jälkeen
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Vaihda nykyinen alkio ja löydetty pienin alkio, jos ne eivät ole samat
                if (minIndex != i)
                {
                    int temp = data[i];
                    data[i] = data[minIndex];
                    data[minIndex] = temp;
                }
            }

            return data;
        }


        public static Dictionary<string, double> SelectionSortByValue(Dictionary<string, double> data)
        {
            List<KeyValuePair<string, double>> list = new List<KeyValuePair<string, double>>(data);

            for (int i = 0; i < list.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].Value < list[minIndex].Value)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    KeyValuePair<string, double> temp = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = temp;
                }
            }

            Dictionary<string, double> sortedDict = new Dictionary<string, double>();
            foreach (KeyValuePair<string, double> pair in list)
            {
                sortedDict.Add(pair.Key, pair.Value);
            }

            return sortedDict;
        }
    }
}