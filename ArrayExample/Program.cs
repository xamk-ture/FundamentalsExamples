namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerot = new int[3];  // Luot uuden kokonaislukutaulukon, joka voi pitää sisällään 3 arvoa.

            numerot[0] = 1;  // Asetat arvon 1 taulukon ensimmäiseen kohtaan.
            numerot[1] = 2;  // Asetat arvon 2 taulukon toiseen kohtaan.
            numerot[2] = 3;  // Asetat arvon 3 taulukon kolmanteen kohtaan.

            for (int i = 0; i < numerot.Length; i++)  // Käyt läpi jokaisen arvon taulukossa ja tulostat sen.
            {
                Console.WriteLine(numerot[i]);  // Tulostat arvon konsoliin.
            }

            // Tuloste:
            // 1
            // 2
            // 3
           
            //Taulukko, johon asetetaan heti arvot
            string[] hedelmat = { "Omena", "Banaani", "Kirsikka" };
            for (int i = 0; i < hedelmat.Length; i++)
            {
                Console.WriteLine(hedelmat[i]);
            }

            //Toinen tapa louda taulukko
            string[] hedelmatToinen = new string[3];
            hedelmatToinen[0] = "Toinen omena";
            hedelmatToinen[1] = "Toinen banaani";
            hedelmatToinen[2] = "Toinen kirsikka";

            for (int i = 0; i < hedelmatToinen.Length; i++)
            {
                Console.WriteLine(hedelmatToinen[i]);
            }
        }
    }
}