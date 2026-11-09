using System;

namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parandatud: Lisatud jutumärgid teksti ümber
            Console.WriteLine("Hello, World!");

            int roundRadius = 3;
            int diameter = roundRadius * 2;
            int pindala = diameter * diameter;
            int ümbermõõt = 4 * diameter;

            Console.WriteLine("Ruudu pindala on: " + pindala);
            Console.WriteLine("Ruudu ümbermõõt on: " + ümbermõõt);

            double roundarea = Math.PI * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;

            // --- LAHENDUS 1: Vormindamine kuvamisel (Soovitatav) ---
            // Kasutame $ märki stringi ees (string interpolation) ja :F2, mis määrab 2 komakohta
            Console.WriteLine($"Ringi pindala on (vormindatud): {roundarea:F2}");
            Console.WriteLine($"Ringi ümbermõõt on (vormindatud): {roundPerimeter:F2}");

            // --- LAHENDUS 2: Arvu enda ümardamine muutujas ---
            double roundedArea = Math.Round(roundarea, 2);
            double roundedPerimeter = Math.Round(roundPerimeter, 2);

            Console.WriteLine("Ringi pindala on (ümardatud): " + roundedArea);
            Console.WriteLine("Ringi ümbermõõt on (ümardatud): " + roundedPerimeter);

            // Hoiab konsooli akna lahti, kuni vajutad suvalist klahvi
            Console.ReadKey();
        }
    }
}
