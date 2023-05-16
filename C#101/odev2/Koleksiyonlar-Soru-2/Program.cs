using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] enBuyukler = new int[3];
            int[] enKucukler = new int[3];
            int enBuyukToplam = 0;
            int enKucukToplam = 0;
            double enBuyukOrtalama = 0;
            double enKucukOrtalama = 0;
            Console.WriteLine("20 adet tam sayı girmeniz istenmektedir.");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i+1}. Sayi: ");
                if (!int.TryParse(Console.ReadLine(), out int sayi))
                    Console.WriteLine("Hatalı giriş yaptınız");
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
            {
                enKucukler[i] = sayilar[i];
                enKucukToplam += sayilar[i];
            }

            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
            {
                enBuyukler[i] = sayilar[i];
                enBuyukToplam += sayilar[i];
            }

            enKucukOrtalama = Convert.ToDouble(enKucukToplam) / 3;
            enBuyukOrtalama = Convert.ToDouble(enBuyukToplam) / 3;

            Console.Write($"En küçüklerin ortalaması: {enKucukOrtalama}");
            Console.WriteLine("\n");
            Console.Write($"En büyüklerin ortalaması: {enBuyukOrtalama}");
            Console.WriteLine("\n");
            Console.Write($"Ortalama toplam: {Convert.ToDouble((enKucukOrtalama + enBuyukOrtalama) / 2)}");

            Console.ReadLine();
        }
    }
}
