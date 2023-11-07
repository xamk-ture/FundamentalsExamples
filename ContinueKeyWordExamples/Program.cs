namespace ContinueKeyWordExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhileContinue();
            ForEachContinue();
        }

        static void WhileContinue()
        {
            Console.WriteLine("While continue example");
            int i = 0;
            while (i < 10)
            {
                i++;

                //Skip even numbers
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static void ForEachContinue()
        {
            Console.WriteLine("ForEach continue example");

            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                //Skip even numbers
                if(number % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(number);
            }
        }
    }
}