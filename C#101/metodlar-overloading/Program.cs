using System;

namespace metodlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir fonksiyonun bir is sonunda bir degeri setlemesini istiyorsak ve o set edilen degeri de kullanmak istiyorsak out parametere olarak verebiliriz.     

            string sayi = "999";

            bool sonuc1 = int.TryParse(sayi, out int outSayi);

            // veya

            int ikinciOutSayi;
            bool sonuc2 = int.TryParse(sayi, out ikinciOutSayi);

            if (sonuc1)
            {
                Console.WriteLine("Sonuc 1 : Basarili");
                Console.WriteLine(outSayi);
            }
            if (sonuc2)
            {
                Console.WriteLine("Sonuc 2 : Basarili");
                Console.WriteLine(ikinciOutSayi);
            }
            else
            {
                Console.WriteLine("Basarisiz.");
            }

            Metodlar metodlar = new Metodlar();
            metodlar.Topla(4, 5, out int toplamaSonucu);
            Console.WriteLine(toplamaSonucu);

            //Metod Overloading (Asiri Yukleme)
            int ifade = 999;
            metodlar.EkranaYazdir(ifade.ToString());
            metodlar.EkranaYazdir(ifade);
            metodlar.EkranaYazdir("Zikriye","Urkmez");

            // Metod imzası:
            // metod adi + parametre sayisi + parametre tipi => bu ucu ayni olursa C# bize kizar. Erisim belirteci ve geri donus tipi metod imzasina dahil DEGILDIR.

            Console.ReadKey();
        }
    }

    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
            //Fonksiyon void olmasina ragmen out ile toplam degerini atayip bunu return etmis gibi davraniyor.
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
