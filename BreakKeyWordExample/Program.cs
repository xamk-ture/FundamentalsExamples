namespace BreakKeyWordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForBreakExample();
            SwitchBreakExample();
        }

        static void ForBreakExample()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break; // ends the loop when i is 5
                }
                Console.WriteLine(i); // prints numbers 1-4
            }
        }

        static void SwitchBreakExample()
        {
            int numero = 3;

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Number is one");
                    break;
                case 2:
                    Console.WriteLine("Number is three");
                    break;
                case 3:
                    Console.WriteLine("Number is three");
                    break;
                default:
                    Console.WriteLine("Number is not one, two or three");
                    break;
            }

        }
    }
}