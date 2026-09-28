namespace IfElseMetgodCall
{
    internal class Program
    {
        //se on meetod Main
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Küsime kasutajalt sisendit
            Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta 'jah':");
            string input = Console.ReadLine();

            // Kontrollime if ja else abil
            if (input != null && input.Trim().ToLower() == "jah")
            {
                HelloMethod();
            }
            else
            {
                Console.WriteLine("Meetodit ei kutsutud välja.");
            }


            // Uus meetod
            static void HelloMethod()
            {
                Console.WriteLine("Veteran");
            }

        }

    }
}   