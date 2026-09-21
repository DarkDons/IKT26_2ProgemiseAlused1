namespace IfAndElseColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Värvide valikus on: red, blue, green ja white");
            Console.Write("Sisesta värv: ");

            string valik = Console.ReadLine().Trim().ToLower();

            if (valik == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;      // Muudab tausta punaseks
                Console.ForegroundColor = ConsoleColor.White;    // Tekst valgeks
                Console.Clear();                                 // Värskendab ekraani uue värviga
                Console.WriteLine("Sisestasid punase värvi (red).");
            }
            else if (valik == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;     // Muudab tausta siniseks
                Console.ForegroundColor = ConsoleColor.White;    // Tekst valgeks
                Console.Clear();
                Console.WriteLine("Sisestasid sinise värvi (blue).");
            }
            else if (valik == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;    // Muudab tausta roheliseks
                Console.ForegroundColor = ConsoleColor.Black;    // Tekst mustaks (loetavuse huvides)
                Console.Clear();
                Console.WriteLine("Sisestasid rohelise värvi (green).");
            }
            else if (valik == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;    // Muudab tausta valgeks
                Console.ForegroundColor = ConsoleColor.Black;    // Tekst mustaks (muidu poleks valgel taustal näha)
                Console.Clear();
                Console.WriteLine("Sisestasid valge värvi (white).");
            }
            else
            {
                // Kui värvi ei lehta, muudame tausta korraks tumepunaseks ja kuvame vea
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Viga: Sellist värvi ei ole valikus!");
            }

            // See rida hoiab konsooli avatuna, et näeksid tulemust
            Console.ReadLine();
        }
    }
}
            
        

    
    

