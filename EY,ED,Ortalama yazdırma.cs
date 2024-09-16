namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ogrenciSayisi = 5;
            string[] ogrenciIsimleri = new string[ogrenciSayisi];
            int[] notlar = new int[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write("Öğrencinin ismini girin: ");
                ogrenciIsimleri[i] = Console.ReadLine();

                Console.Write($"{ogrenciIsimleri[i]} isimli öğrencinin notunu girin: ");
                notlar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n Öğrencilerin notları:");
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"{ogrenciIsimleri[i]}: {notlar[i]}");
            }
            int enYuksekNot = notlar[0];
            int enDusukNot = notlar[0];
            string enYuksekOgrenci = ogrenciIsimleri[0];
            string enDusukOgrenci = ogrenciIsimleri[0];

            for (int i = 1; i < ogrenciSayisi; i++)
            {
                if (notlar[i] > enYuksekNot)
                {
                    enYuksekNot = notlar[i];
                    enYuksekOgrenci = ogrenciIsimleri[i];
                }
                if (notlar[i] < enDusukNot)
                {
                    enDusukNot = notlar[i];
                    enDusukOgrenci = ogrenciIsimleri[i];
                }
            }

            Console.WriteLine($"\nEn yüksek not: {enYuksekOgrenci} aldı, Not: {enYuksekNot}");
            Console.WriteLine($"En düşük not: {enDusukOgrenci} aldı, Not: {enDusukNot}");

            double ortalama = 0;
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                ortalama += notlar[i];
            }
            ortalama /= ogrenciSayisi;

            Console.WriteLine($"\nNotların ortalaması: {ortalama:F2}");

            Console.ReadLine();
        }
    }
}

