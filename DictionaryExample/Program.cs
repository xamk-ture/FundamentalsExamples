namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person example
            Dictionary<string, string> persons = new Dictionary<string, string>();
            persons.Add("123456-123A", "Matti Meikäläinen");
            string keyPerson = persons["123456-123A"];

            //Highscore example
            Dictionary<string, double> highScores = new Dictionary<string, double>();
            highScores.Add("Jack", 20.5);


            // Luot uuden sanakirjan, joka voi pitää sisällään merkkijonoja.
            Dictionary<string, string> sanakirja = new Dictionary<string, string>();

            sanakirja.Add("Apple", "Hedelmä, joka on yleensä punainen tai vihreä.");  // Lisäät arvoparin sanakirjaan.
            sanakirja.Add("Banana", "Pitkä ja keltainen hedelmä.");  // Lisäät toisen arvoparin sanakirjaan.

            string appleKuvaus = sanakirja["Apple"];  // Haet arvon avaimella "Apple".
            string bananaKuvaus = sanakirja["Banana"];  // Haet arvon avaimella "Banana".

            sanakirja["Banana"] = "Uusi kuvaus banaanille"; //Muutetaan arvoa avaimella "Banana"    

            Console.WriteLine(appleKuvaus);  // Tulostat arvon konsoliin.
            Console.WriteLine(bananaKuvaus);  // Tulostat toisen arvon konsoliin.

            // Tuloste:
            // Hedelmä, joka on yleensä punainen tai vihreä.
            // Pitkä ja keltainen hedelmä.

            //tulosta kaiikki dictionaryn valuet
            foreach (string value in sanakirja.Values)
            {
                Console.WriteLine(value);
            }

            //tulosta kaikki dictionaryn avaimet
            foreach (string avain in sanakirja.Keys)
            {
                Console.WriteLine(avain);
            }

            //Tulostetaan kaikki avaimet ja niiden arvot 
            //Huom KeyValuePair<string, string> voi ilmaista lyhyemmin myös käyttämällä vain var avainsanaa
            //Eli foreach (var sana in sanakirja)
            //Tässä esimerkissä käytetään oikea tyyppiä, jotta esimerkki on selkeämpi
            foreach (KeyValuePair<string,string> sana in sanakirja)
            {
                Console.WriteLine($"Key:{sana.Key} Value:{sana.Value}");
            }

            // Oletetaan, että käyttäjä valitsee kielen (englanti tai suomi).
            string valittuKieli = "fi";  // esimerkiksi suomi

            // Luodaan sanakirjat eri kielille.
            Dictionary<string, string> englishTranslations = new Dictionary<string, string>
            {
                { "greeting", "Hello" },
                { "farewell", "Goodbye" }
            };

            Dictionary<string, string> finnishTranslations = new Dictionary<string, string>
            {
                { "greeting", "Hei" },
                { "farewell", "Näkemiin" }
            };

            // Valitaan oikea sanakirja käyttäjän valitseman kielen perusteella.
            Dictionary<string, string> translations = valittuKieli == "en" ? englishTranslations : finnishTranslations;

            // Tulostetaan tervehdys ja hyvästit käyttäjän valitsemalla kielellä.
            Console.WriteLine(translations["greeting"]);  // Tulostaa "Hei"
            Console.WriteLine(translations["farewell"]);  // Tulostaa "Näkemiin"

        }

        /// <summary>
        /// Demo how to check if dictionary contains given key
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        static int? GetCityPopulation(string city)
        {
            Dictionary<string, int> cities = new();
            cities.Add("Mikkeli", 5000000);
            cities.Add("Kuopio", 100000);
            cities.Add("Helsinki", 500000);

            int? population = null;

            //Checks if dictionary has the key before trying to get the value
            if (cities.ContainsKey(city))
            {
                population = cities[city];
            }
            else
            {
                Console.WriteLine("City is not found");
            }

            return population;
        }
    }
}