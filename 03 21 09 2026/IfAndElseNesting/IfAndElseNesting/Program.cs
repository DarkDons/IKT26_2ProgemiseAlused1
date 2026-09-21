using System.Threading.Channels;

namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("teise else if-i sisse panna if ja else");

            string number = Console.ReadLine();
            int nr = int.Parse(number);

            if (nr == 12)
            {

            }
            else if (nr > 20)
            {
                //nestimine e pesastamine
                if (nr == 25)
                {
                    Console.WriteLine("number 25");
                }
                else
                {
                    Console.WriteLine("Kõik numbrid peale 25-e");
                }
            }    
            else
            {
                Console.WriteLine("kahtlane number");
            }
            
        }
    }
}
