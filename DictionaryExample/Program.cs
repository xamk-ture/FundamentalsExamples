﻿namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Luot uuden sanakirjan, joka voi pitää sisällään merkkijonoja.
            Dictionary<string, string> sanakirja = new Dictionary<string, string>();

            sanakirja.Add("Apple", "Hedelmä, joka on yleensä punainen tai vihreä.");  // Lisäät arvoparin sanakirjaan.
            sanakirja.Add("Banana", "Pitkä ja keltainen hedelmä.");  // Lisäät toisen arvoparin sanakirjaan.

            string appleKuvaus = sanakirja["Apple"];  // Haet arvon avaimella "Apple".
            string bananaKuvaus = sanakirja["Banana"];  // Haet arvon avaimella "Banana".

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
    }
}