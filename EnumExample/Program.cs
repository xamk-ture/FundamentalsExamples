namespace EnumExample
{
    internal class Program
    {
        enum Game { Basic = 1, Advanced = 2, Expert = 3 }

        static void Main(string[] args)
        {

            Console.WriteLine("Valitse peli jota haluat pelata: 1: Perus peli, 2: Advanced peli");

            int gameChoice = Convert.ToInt16(Console.ReadLine());

            if(gameChoice == (int)Game.Basic)
            {
                
            }
            else if(gameChoice == (int)Game.Advanced) 
            {
                
            }


        }

        static void Demo()
        {
            int gameChoice = Convert.ToInt16(Console.ReadLine());

            if (gameChoice == (int)Game.Basic)
            {

            }
            else if (gameChoice == (int)Game.Advanced)
            {

            }

        }
    }
}
