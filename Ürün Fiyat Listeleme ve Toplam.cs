namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal toplamFiyat = 0;
            int urunSayisi = 0;

            do
            {
                try
                {
                    Console.WriteLine("Kaç adet ürün gireceksiniz ?");
                    urunSayisi = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Geçerli bir sayı giriniz.");
                }
            } 
            while (urunSayisi <= 0);

            int sayac = 0;

            while (sayac < urunSayisi)
            {
                try
                {
                    Console.WriteLine($"{sayac + 1}. ürünün fiyatını giriniz:");
                    decimal fiyat = Convert.ToDecimal(Console.ReadLine());
                    toplamFiyat += fiyat;
                    sayac++;
                }
                catch
                {
                    Console.WriteLine("Geçerli bir fiyat giriniz.");
                }
            }
            Console.WriteLine($"Toplam ürün fiyatı: {toplamFiyat} TL");
        }
    }
}
