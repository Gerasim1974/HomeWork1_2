namespace ConsoleApp1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter start number");
            string? sStartNumber = Console.ReadLine();
            int nStartNumber = int.Parse(sStartNumber);
            Console.WriteLine("please enter end number");
            string? sEndNumber = Console.ReadLine();
            int nEndNumber = int.Parse(sEndNumber);
            Console.WriteLine("Result:");
            while (nStartNumber <= nEndNumber)
            {
                Console.WriteLine(nStartNumber);
                nStartNumber++;
            }
            Console.ReadKey();
        }
    }
}