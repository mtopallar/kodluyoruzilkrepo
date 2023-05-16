using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int asalKontrol = 0;
            double asalToplam = 0;
            double asalOlmayanToplam = 0;

            Console.WriteLine("20 adet sayi pozitif tamsayı girmeniz gerekmektedir.");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i}. Sayıyı Giriniz:");
                if (!int.TryParse(Console.ReadLine(), out int sayi) || sayi <= 0)
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    return;
                }
                for (int j = 1; j <= sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        asalKontrol++;
                    }
                }
                if (asalKontrol == 2)
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanSayilar.Add(sayi);
                asalKontrol = 0;
            }
            Console.WriteLine("\n");

            asalSayilar.Sort();
            asalSayilar.Reverse();
            Console.WriteLine("Asal sayılar büyükten küçüğe:");
            foreach (var item in asalSayilar)
            {
                Console.Write($"{item} ");
                asalToplam += Convert.ToInt32(item);
            }
            Console.WriteLine("\n");

            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            Console.WriteLine("Asal olmayan sayılar büyükten küçüğe:");
            foreach (var item in asalOlmayanSayilar)
            {
                Console.Write($"{item} ");
                asalOlmayanToplam += Convert.ToInt32(item);
            }
            Console.WriteLine("\n");
            //Console.Out.NewLine = "\n";
            Console.WriteLine($"Asal olan {asalSayilar.Count} sayının ortalaması: {asalToplam / asalSayilar.Count}");
            Console.WriteLine($"Asal olmayan {asalOlmayanSayilar.Count} sayının ortalaması: {asalOlmayanToplam / asalOlmayanSayilar.Count}");

            Console.ReadLine();
        }
    }
}
