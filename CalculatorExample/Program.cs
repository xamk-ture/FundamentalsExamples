namespace CalculatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä x");
            var x = Console.ReadLine();

            Console.WriteLine("Syötä y");

            var y = Console.ReadLine();

            Console.WriteLine("Minkä operaation haluat suorittaa: ");
            Console.WriteLine("Saatavilla olevat operaatiot: summa, jako, miinus, kerto");

            //kerto = *
            //plussa = +
            //miinus = -
            //jako = /
            var operaatio = Console.ReadLine();

            int result = Calculate(int.Parse(x), int.Parse(y), operaatio);

            Console.WriteLine($"Interpolation example: Result {x} {operaatio} {y} = {result}");
        }

        public static int Calculate(int x, int y, string operaatio)
        {
            int result = 0;

            if (operaatio == "summa")
            {
                result = x + y;
            }
            else if (operaatio == "miinus")
            {
                result = x - y;
            }

            return result;
        }
    }
}