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
            int numero2 = 0;

            //tämä kaatuu, koska merkkijono sisältää muitakin merkkejä kuin numeroja
            try
            {
                numero = int.Parse(merkkiJono);

                //toinen tapa tehdä konvertio
                numero2 = Convert.ToInt16(merkkiJono);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Konversio epäonnistui, koska merkkijono sisälsi muitakin kuin numeroja");
            }

            //tämä onnistuu, koska merkkijono sisältää vain numeroja

            Console.WriteLine("int.parse konversio");
            numero = int.Parse(numeroJono);
            Console.WriteLine(numero);

            Console.WriteLine("Convert.ToInt32 konversio");
            numero2 = Convert.ToInt32(numeroJono);
            Console.WriteLine(numero2);

            bool onnistuikoKonversio = false;

            //huomaa, että TryParse palauttaa booleanin, joka kertoo onnistuiko konversio
            //Ja jos konversio onnistuu, niin numero muuttujaan tulee konvertoitu arvo
            onnistuikoKonversio = int.TryParse(merkkiJono, out numero);

            if(onnistuikoKonversio == false)
            {
                Console.WriteLine($"Konversio ei onnistunut merkkijonolle: {merkkiJono}");
            }

            onnistuikoKonversio = int.TryParse(numeroJono, out numero);

            if (onnistuikoKonversio == true)
            {
                Console.WriteLine($"Konversio onnistui merkijonolle: {numeroJono}");
            }

            //Mitä tryParse yrittää tehdä pellin alla
            //bool koversioOnnistui = false;

            //if (merkkiJono == "onjotain muutakuin numeroita")
            //{
            //    koversioOnnistui = false;
            //}
            //else
            //{
            //    numero = int.Parse(merkkiJono);
            //    koversioOnnistui = true;<e
            //}
            //
            //retun koversioOnnistui;
        }
    }
}