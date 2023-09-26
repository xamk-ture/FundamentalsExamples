namespace NullExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = null;

            try
            {
                // Yritetään kutsua metodia null-arvolla, mikä aiheuttaa NullReferenceExceptionin
                int length = text.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Poikkeus: {ex.Message}");
            }
        }
    }
}