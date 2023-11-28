namespace RecursionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int factorial = Factorial(5);

            Console.WriteLine(factorial);

            RecursiveFailExample();
        }

        /// <summary>
        /// Faktoriaali n! on luku n kerrottuna kaikilla positiivisilla kokonaisluvuilla sen alapuolella.
        /// Esimerkiksi 5 ! = 5 × 4 × 3 × 2 × 1 5!=5×4×3×2×1=120.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Factorial(int n)
        {
            if (n == 0) // Rekursion lopetusehto
                return 1;
            else
                return n * Factorial(n - 1); // Rekursiivinen kutsu
        }

        /// <summary>
        /// This fuction will cause stack overflow exception
        /// </summary>
        /// <returns></returns>
        public static int RecursiveFailExample()
        {
            return RecursiveFailExample();
        }

    }
}