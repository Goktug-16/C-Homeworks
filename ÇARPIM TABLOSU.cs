namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{sayi} x {i} = {sayi * i}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
        }
    }
}
