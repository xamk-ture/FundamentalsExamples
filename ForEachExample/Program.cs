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
        }
    }
}