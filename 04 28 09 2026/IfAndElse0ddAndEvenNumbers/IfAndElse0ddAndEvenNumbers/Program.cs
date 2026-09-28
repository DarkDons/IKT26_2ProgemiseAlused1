using System;

namespace IfAndElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Küsime kasutajalt sisendit
            Console.Write("Palun sisesta üks täisarv: ");
            string sisend = Console.ReadLine();

            // Parsime sisestatud teksti täisarvuks (int)
            int number = int.Parse(sisend);

            // Kontrollime jäägi operaatori (%) abil, kas arv jagub kahega
            if (number % 2 == 0)
            {
                Console.WriteLine($"Arv {number} on paarisarv.");
            }
            else
            {
                Console.WriteLine($"Arv {number} on paaritu arv.");
            }
        }
    }
}