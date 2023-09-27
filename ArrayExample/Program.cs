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
        }
    }
}