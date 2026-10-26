using System;

namespace WhileDoTriangel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programm, mis prindib numbrid while-tsükli abil kolmnurga kujule
            int ridadearv = 5;
            int rida = 1;

            while (rida <= ridadearv)
            {
                int veerg = 1;
                while (veerg <= rida)
                {
                    Console.Write(veerg + " ");
                    veerg++;
                }
                Console.WriteLine(); // Viib kursori järgmisele reale
                rida++;
            }
        }
    }
}
