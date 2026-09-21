namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha jalanumbri suurusest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline),
            //teine jalanumbri 34-38 /siin o tagataust valge),
            //kolmas jalanumberi 45 - 48 (siin teeb arvuti häält beep)
            //kus kasutatakse mõnda teist jalanumbrit.
            Console.WriteLine("Sisesta jalanumber");

            {
                // Teha jalanumbri suurusest üks if ja else harjutus.
                Console.WriteLine("Sisesta jalanumber:");

                // Loeme sisendi ja muudame selle täisarvuks (int)
                int jalanumber = Convert.ToInt32(Console.ReadLine());

                // Enne kontrolli lähtestame konsooli värvid tavapäraseks
                Console.ResetColor();

                // Esimene tingimus: jalanumber 30 - 33 (tekst roheline)
                if (jalanumber >= 30 && jalanumber <= 33)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jalanumber on vahemikus 30-33. Tekst on roheline!");
                }
                // Teine tingimus: jalanumber 34 - 38 (tagataust valge)
                else if (jalanumber >= 34 && jalanumber <= 38)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black; // Muudame teksti mustaks, et see oleks valgel taustal nähtav
                    Console.Clear(); // Värvib kogu tausta valgeks
                    Console.WriteLine("Jalanumber on vahemikus 34-38. Taust on valge!");
                }
                // Kolmas tingimus: jalanumber 45 - 48 (arvuti teeb häält beep)
                else if (jalanumber >= 45 && jalanumber <= 48)
                {
                    Console.WriteLine("Jalanumber on vahemikus 45-48. Arvuti teeb häält!");
                    Console.Beep(); // Teeb "beep" heli
                }
                // Viimane tingimus: mõni muu jalanumber
                else
                {
                    Console.WriteLine("Sisestasid mõne muu jalanumbri (see ei mahtunud ühtegi vahemikku).");
                }

                // Hoiab konsooli avatuna
                Console.ReadLine();

                //siin on muutuja nimega name,
                //mis tüübiga sting
                //loeb andmeid konsoolist ja salvestab
                //need muutuja name sisse
                string name = Console.ReadLine();

                //if ja else kontrollib, kas muutuja
                //name on tühi või mitte

                //kui muutuja name on yühi, siis väljastab konsoolile
                //teksti "tere, tundmatu! Error" ja teeb 4 piiksu
                if (name != "")
                {
                    Console.WriteLine("tere, " + name);
                }
                else
                {
                    Console.WriteLine("tere tundmatu! liiga noor  ERROR");
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Beep();
                    Thread.Sleep(1000);

                }
            }

        } 
    }


