using System;

namespace Ruutmeetrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Küsime kasutajalt sisendit
            Console.Write("Sisesta maja suurus ruutmeetrites: ");
            string sisend = Console.ReadLine();

            // Teisendame sisestatud teksti arvuks (int)
            if (int.TryParse(sisend, out int suurus))
            {
                // 1. kontroll: 0 kuni 40 ruutmeetrit
                if (suurus >= 0 && suurus <= 40)
                {
                    Console.WriteLine("Sinu maja on väike (0-40 rm).");
                }
                // 2. kontroll: 41 kuni 90 ruutmeetrit
                else if (suurus >= 41 && suurus <= 90)
                {
                    Console.WriteLine("Sinu maja on keskmise suurusega (41-90 rm).");
                }
                // 3. kontroll: 91 kuni 130 ruutmeetrit
                else if (suurus >= 91 && suurus <= 130)
                {
                    Console.WriteLine("Sinu maja on üsna suur (91-130 rm).");
                }
                // 4. kontroll: mis tahes muu tuvastatud suurus (nt üle 130)
                else
                {
                    Console.WriteLine($"Sinu maja suurus on {suurus} ruutmeetrit.");
                }
            }
            else
            {
                Console.WriteLine("Viga! Palun sisesta korrektne täisarv.");
            }
        }
    }
}
