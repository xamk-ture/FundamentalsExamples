namespace EnumExample
{
    internal class Program
    {
        enum Game { Basic = 1, Advanced = 2, Expert = 3 }

        static void Main(string[] args)
        {
            Console.WriteLine("Valitse peli jota haluat pelata: 1: Perus peli, 2: Advanced peli");

            int gameChoice = Convert.ToInt16(Console.ReadLine());

            //using enums makes code more readable
            if(gameChoice == (int)Game.Basic)
            {
                
            }
            else if(gameChoice == (int)Game.Advanced) 
            {
                
            }

            //the same code written without enums
            //now we don't see in code straight away that what one means
            //in above example we can just read that what the 1 stands for
            //and that makes code more easier to maintain and read
            if(gameChoice == 1)
            {

            }
            else if(gameChoice == 2)
            {

            }
        }
    }
}
