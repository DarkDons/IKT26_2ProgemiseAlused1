namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk, täisnurkne kolmnurk");
            Console.WriteLine("---------------------------------------");
            // \n teeb tühja rea
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            // Välimine tsükkel määrab ridade arvu
            for (i = 1; i <= rows; i++)
            {
                // Sisemine tsükkel prindib igale reale vastava arvu tärne
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                // Kui rida on valmis, liigume järgmisele reale
                Console.WriteLine();
            }
        }
    }
}

