namespace ForEachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alustetaan string-tyyppinen taulukko, joka sisältää eri eläimiä.
            string[] elaimet = { "Koira", "Kissa", "Hevonen", "Kani" };

            // 'foreach' -silmukkaa käytetään käymään läpi kaikki taulukon (tai muiden kokoelmatyyppien) elementit yksi kerrallaan.
            // Tässä esimerkissä 'elain' on väliaikainen muuttuja, joka saa arvokseen kulloisenkin taulukon elementin.
            foreach (string elain in elaimet)
            {
                // Tulostetaan kulloisenkin taulukon elementin arvo.
                Console.WriteLine(elain);
            }

            // Ohjelman suorituksen lopussa näet tulostuksen:
            // Koira
            // Kissa
            // Hevonen
            // Kani

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };


            //foreachin sisälle voidaan myös tehdä logiikkaa. Tässä tapauksessa tulostetaan vain rivit, joidenka arvo
            //on suurempi kuin 2
            foreach (var number in numbers)
            {
                if(number > 2)
                    Console.WriteLine(number);
            }
        }
    }
}