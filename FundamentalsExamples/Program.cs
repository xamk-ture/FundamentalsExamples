namespace FundamentalsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anna etunimesi");

            //luetaan etunimi käyttäjältä
            var firstName = Console.ReadLine();

            Console.WriteLine($"Terve {firstName} hyvää päivää!");

            Console.WriteLine($"Anna sukunimesi");

            //luetaan sukunimi käyttäjältä
            var lastName = Console.ReadLine();

            //Poistaa nimestä kaikki välilyönnit
            firstName = firstName.Replace(" ", "");

            //tai toinen tekniikka, joka myös poistaa turhat välilyönnit
            lastName = lastName.Trim();

            firstName = CapitalizeFirstLetter(firstName);
            lastName = CapitalizeFirstLetter(lastName);

            Console.WriteLine($"Hei {firstName} {lastName}, mukavaa koodailuu :)");
        }

        private static string CapitalizeFirstLetter(string? inputString)
        {
            /*inputString.First().ToString().ToUpper(): Ottaa ensimmäisen merkin inputString-merkkijonosta, 
             * muuttaa sen takaisin merkkijonoksi char tyyppisestä muuttujasta ja muuttaa sen isoksi kirjaimeksi (eli alkukirjaimeksi).

             inputString.Substring(1).ToLower(): Ottaa inputString-merkkijonon loput merkit ensimmäisen merkin jälkeen ja muuttaa ne pieniksi kirjaimiksi.
             Lopuksi yllä mainitut kaksi osaa yhdistetään yhteen merkkijonoon käyttäen + -operaattoria.
             Koodin tulos on, että inputString-merkkijonon ensimmäinen kirjain muutetaan isoksi kirjaimeksi ja kaikki muut merkit pieniksi kirjaimiksi. 
             Esimerkiksi jos inputString oli alun perin "hELLo", sen arvo koodin suorittamisen jälkeen on "Hello".
            */

            inputString = inputString.First().ToString().ToUpper() + inputString.Substring(1).ToLower();
            return inputString;
        }
    }
}