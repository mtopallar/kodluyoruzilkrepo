using System;
using System.Collections.ObjectModel;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5]; //5 elemanlı renkler dizisi. Boyut belli ama elemanlar değil.
            string[] hayvanlar = {"kedi","kopek","kus","maymun"};
            //string[] hayvanlar = new string[] {"kedi","kopek","kus","maymun"}; //yukaridakinin alternatif yazilis sekli.
            int[] dizi;
            dizi = new int[5]; //5 elemanli.

            //Dizilere deger atama ve erisim:
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Donguler ile dizi kullanimi
            //Klavyeden girilen n tane sayinin ortalamasini alan program.
            Console.Write("Kac sayinin ortalamasini almak istersiniz?");
            int[] sayilar = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < sayilar.Length; i++)
            {
                //Console.Write($"Lutfen {i+1}.sayiyi giriniz: ");
                Console.Write("Lutfen {0}.sayiyi giriniz: ", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine($"Ortalama : {toplam / sayilar.Length}");
            Console.ReadLine();

        }
    }
}
