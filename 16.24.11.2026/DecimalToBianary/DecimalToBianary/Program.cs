namespace DecimalToBianary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary!");

            Console.WriteLine("Sisesta number: ");

            int number = int.Parse(Console.ReadLine());
            string binaar = "";

            while (number > 0)
            {
                binaar = (number % 2) + binaar;
                number /= 2;
            }

            Console.WriteLine(binaar == "" ? "0" : binaar);
        }
    }
}
