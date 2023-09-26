namespace BooleanExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onkoTosi = true;

            if (onkoTosi)
            {
                Console.WriteLine("Muuttuja on tosi.");
            }
            else
            {
                Console.WriteLine("Muuttuja ei ole tosi.");
            }

            int luku1 = int.Parse(Console.ReadLine());

            bool isParseSuccesfull = int.TryParse(Console.ReadLine(), out int luku2);

            if(isParseSuccesfull)
            {
                Console.WriteLine("Luku2 onnistui");
            }
            else
            {
                Console.WriteLine("Luku2 ei onnistunut");

                return;
            }

            bool onkoPienempi = luku1 < luku2 ;  // Tämä antaa arvon 'true', koska 5 on pienempi kuin 10.


            if (onkoPienempi)
            {                
                Console.WriteLine("Luku1 on pienempi kuin luku2");
            }
            else
            {
                Console.WriteLine("Luku1 ei ole pienempi kuin luku2");
            }

            bool isompiVertailu = luku1 < luku2 || (luku1 > luku2) && (luku2 != luku1);

            //Vaikea lukuisempi
            if (luku1 < luku2 || (luku1 > luku2) && (luku2 != luku1))
            {

            }

            //Helppo lukuisempi
            if(isompiVertailu)
            {

            }
        }
    }
}