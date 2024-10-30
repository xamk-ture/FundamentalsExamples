namespace WhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            While();
            DoWhile();
        }

        static void While()
        {
            int count = 1;

            // The loop will continue as long as 'count' is less than or equal to 5
            while (count <= 5)
            {
                Console.WriteLine("Count is: " + count);
                count++; // Increment 'count' by 1
            }

            Console.WriteLine("While loop ended.");
        }

        static void DoWhile()
        {
            int number;

            // The loop will execute at least once
            do
            {
                Console.Write("Enter a positive number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            // The condition is checked after the loop body executes
            while (number <= 0);

            Console.WriteLine("You entered: " + number);
        }
    }
}
