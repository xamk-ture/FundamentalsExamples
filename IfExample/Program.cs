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


            Console.WriteLine("Give your name");

            string name = Console.ReadLine();

            //name.Length retruns how long the name string is
            if(name.Length >= 10)
            {
                Console.WriteLine("Your name is longer than 10 letters");
            }
            else
            {
                Console.WriteLine("Your name is shorter than 10 letters")
            }

        }
    }
}
