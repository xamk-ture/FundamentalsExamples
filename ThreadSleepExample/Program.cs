namespace ThreadSleepExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan odottaminen...");
            Thread.Sleep(3000);  // Odottaa 3 sekuntia (3000 millisekuntia).
            Console.WriteLine("Odottaminen päättyi!");
        }
    }
}