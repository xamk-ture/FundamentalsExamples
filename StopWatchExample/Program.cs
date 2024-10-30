using System.Diagnostics;

namespace StopWatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();  // Luo uuden Stopwatch-olion.
            stopWatch.Start();  // Käynnistää ajanoton.

            // Oletetaan, että tässä on koodi, jonka suoritusaikaa haluat mitata.
            Thread.Sleep(1000);  // Odottaa 1 sekunti (1000 millisekuntia).

            stopWatch.Stop();  // Pysäyttää ajanoton.

            TimeSpan ts = stopWatch.Elapsed;  // Hakee kuluneen ajan.

            // Tulostaa kuluneen ajan millisekunteina.
            Console.WriteLine($"Aikaa kului: {ts.TotalMilliseconds}ms");

            Console.ReadLine();
        }
    }
}