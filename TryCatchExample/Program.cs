namespace TryCatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IndexOutOfBoundsExample();

            DivideByZeroExceptionExample();
        }

        static void IndexOutOfBoundsExample()
        {
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine(numbers[1]);

            try
            {
                Console.WriteLine(numbers[5]); //this will crash
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Syötä oikea numero");
            }
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