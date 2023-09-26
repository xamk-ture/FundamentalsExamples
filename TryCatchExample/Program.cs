namespace TryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DivideByZeroExceptionExample();

           
        }

        private static void DivideByZeroExceptionExample()
        {
            try
            {
                int number = 10;
                int result = number / 0;  // Tämä aiheuttaa DivideByZeroException
            }
            catch (DivideByZeroException ex) //huomaa, että tässä ei ole exception muuttujaa, koska sitä ei käytetä, kuten InvalidFormatExample() metodissa
            {
                Console.WriteLine("Jakoa nollalla ei sallita.");
            }
            finally
            {
                Console.WriteLine("Tämä suoritetaan aina");
            }

            Console.WriteLine("Jatkuu");
        }
    }
}