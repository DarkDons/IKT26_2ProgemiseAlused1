namespace TryCashSwich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("valisid 2");
                        break;

                    default:
                        break;
                }

            }
            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("palun sisesta number");
            }
            catch
            {
                Console.WriteLine("number on liiga suur");
        
            }
        }
    }
}
