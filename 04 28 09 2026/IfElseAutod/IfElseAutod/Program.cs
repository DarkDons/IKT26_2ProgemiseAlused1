namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali auto valikus on Škoda, BMW, Porsche, AudiS!");
            //Kasutada if ja else
            //Kirjuta automark
            //Valikus on BMW, Audi, Porche ja Škoda
            //Kui valitakse Škoda, siis seal sees on uuesti küsimus, et
            //mis mudelit soovid valida. Mudeli valikus kodiaq ja Octavia
            string mudel = "";

            string mark = Console.ReadLine();

            if (mark == "BMW")
            {
                Console.WriteLine("Vali mudel (M1, M2, M3, M4, M5): ");
                mudel = Console.ReadLine();

                if (mudel == "M2") Console.WriteLine("BMW M2.");
                else if (mudel == "M4") Console.WriteLine("BMW M4.");
                else Console.WriteLine("Tundmatu mudel.");
            }
            else if (mark == "Audi")
            {
                Console.WriteLine("Valisid Audi.");



                Console.WriteLine("Vali mudel (RS3, RS6): ");
                mudel = Console.ReadLine();

                if (mudel == "RS6") Console.WriteLine("Audi RS6");
                else if (mudel == "RS3") Console.WriteLine("Audi RS3.");
                else Console.WriteLine("Tundmatu mudel.");

            }
            else if (mark == "Porsche")
            {
                Console.WriteLine("Valisid Porsche.");

                Console.WriteLine("Vali mudel (GT2, GT3): ");
                mudel = Console.ReadLine();

                if (mudel == "GT2") Console.WriteLine("Valisid Porsche GT2");
                else if (mudel == "GT3") Console.WriteLine("Valisid Porsche GT3.");
                else Console.WriteLine("Tundmatu mudel.");
            }
            if (mark == "Škoda")
            {
                Console.WriteLine("Vali mudel (Kodiaq, Octavia): ");
                mudel = Console.ReadLine();

                if (mudel == "Kodiaq") Console.WriteLine("Valisid Škoda Kodiaq.");
                else if (mudel == "Octavia") Console.WriteLine("Valisid Škoda Octavia.");
                else Console.WriteLine("Tundmatu mudel.");
            }
           

        }
    }
}
