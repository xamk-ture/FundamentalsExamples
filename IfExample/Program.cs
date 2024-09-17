namespace IfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If example that compares numbers");

            Console.WriteLine("Give number 1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give number 2");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2) 
            {
                Console.WriteLine("The first number inputted is bigger");
            }
            else if(num1 < num2) 
            {
                Console.WriteLine("The second number inputted is bigger");
            }
            else if(num1 == num2)
            {
                Console.WriteLine("The number is same");
            }


        }
    }
}
