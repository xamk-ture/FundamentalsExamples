namespace SwitchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3:");
            int choice = Convert.ToInt32(Console.ReadLine());

            string stringChoice = "Test";

            switch(stringChoice)
            {
                case "Demo":
                    Console.WriteLine("Demo triggered");
                    int dd = 1 + 1;
                    break;
                case "Test":
                    Console.WriteLine("Test triggered");
                    break;
            }

            // Switch statement to handle different cases for 'choice'
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose option 1.");
                    break; // Ends this case and exits the switch block

                case 2:
                    Console.WriteLine("You chose option 2.");
                    break;

                case 3:
                    Console.WriteLine("You chose option 3.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    break;
            }

            
            //Same in if statements, but just no code inside the statements
            if(choice == 1)
            {

            }
            else if(choice == 2)
            {

            }
            else
            {

            }

            Console.WriteLine("Switch statement ended.");
        }
    }
}
