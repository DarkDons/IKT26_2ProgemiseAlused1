using System.Xml.Linq;

namespace ifAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta enda vanus");

            //peate kasutama if and else lauseid,
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väiksem kui 18

            //int userAge = Convert.ToInt32/console.ReadLine());
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            if (userAge >= 18)
            {
                Console.WriteLine("sa oled täisealine");
            }
            else
            {
                Console.WriteLine("sa oled alaealine");
            }
        }
    }
}
