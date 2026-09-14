using System.Security.Cryptography.X509Certificates;

namespace ifAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ain-hanree!");

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
