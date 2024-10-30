namespace RandomExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random example");

            Random random = new();

            int randomNumber = random.Next(1000);

            Console.WriteLine(randomNumber);
        }
    }
}
