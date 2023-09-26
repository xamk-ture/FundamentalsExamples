namespace IntParseExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijono numeroksi demo");

            string merkkiJono = "Tekstiä 10";
            string numeroJono = "123";

            int numero = 0;

            //tämä kaatuu, koska merkkijono sisältää muitakin merkkejä kuin numeroja
            numero = int.Parse(merkkiJono);

            //tämä onnistuu, koska merkkijono sisältää vain numeroja
            numero = int.Parse(numeroJono); 

            bool onnistuikoKonversio = false;

            //huomaa, että TryParse palauttaa booleanin, joka kertoo onnistuiko konversio
            //Ja jos konversio onnistuu, niin numero muuttujaan tulee konvertoitu arvo
            onnistuikoKonversio = int.TryParse(merkkiJono, out numero);
            Console.WriteLine($"Konversio ei onnistunut {merkkiJono}");

            onnistuikoKonversio = int.TryParse(numeroJono, out numero);
            Console.WriteLine($"Konversio onnistui {onnistuikoKonversio}");
        }
    }
}