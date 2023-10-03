namespace ForExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tämä koodi suorittaa tulostamisen 5 kertaa. Muuttamalla i:n tai 5 arvoa,
            //voit muuttaa kuinka monta kertaa tulostetaan
            //i on lyhenny iteraatiosta, joka tarkoittaa toistoa
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteraatio numero {i}"); 
            }

            string[] hedelmat = { "Omena", "Banaani", "Kirsikka" };
            for (int i = 0; i < hedelmat.Length; i++)
            {
                Console.WriteLine(hedelmat[i]);
            }
        }
    }
}