namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();  // Luodaan uusi lista, joka säilyttää int-tyypin arvoja

            numbers.Add(1);  // Lisätään arvo 1 listaan
            numbers.Add(2);  // Lisätään arvo 2 listaan
            numbers.Add(3);  // Lisätään arvo 3 listaan

            foreach (int number in numbers)  // Tulostetaan jokainen numero listasta
            {
                Console.WriteLine(number);
            }

            // Output:
            // 1
            // 2
            // 3


            int indeksiDemo = numbers[2];

            Console.WriteLine($"Indeksi demo {indeksiDemo}");

            numbers.RemoveAt(0);

            Console.WriteLine("RemoveAt demo");

            foreach (int number in numbers)  // Tulostetaan jokainen numero listasta
            {
                Console.WriteLine(number);
            }



            numbers.Remove(2);  // Poistetaan arvo 2 listasta

            Console.WriteLine("Remove demo");

            foreach (int number in numbers)  // Tulostetaan jokainen numero listasta
            {
                Console.WriteLine(number);
            }


            //Toinen tapa luoda lista
            //List<int> numbers2 = new List<int>() { 1, 2, 3 };

            //foreach (int number in numbers2)  // Tulostetaan jokainen numero listasta
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}