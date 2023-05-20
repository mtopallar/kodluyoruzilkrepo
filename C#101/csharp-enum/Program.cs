using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            enumaration (sıralama)
            Birden fazla sabite (değeri belli olan duruma) ihtiyacımız varsa kullanılabilir.
            Pazartesi = 1 dersem Pazartesinin indexi 1 olur ve diğerleri otomatik olarak artar.
            Aslında hep ardışık gider biz Cuma ya 23 dersek Cumartesi otomatik olarak 24 olur. Cumadan öncekiler de eğer aksi bir değer atamadıysak 0,1,2,3 şeklinde devam eder. Sonra 23,24,25 diye devam eder.
            */
            Console.WriteLine(Gunler.Pazar); // => Pazar
            Console.WriteLine((int)Gunler.Cumartesi); //5

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin.");
            else if(sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
                Console.WriteLine("Haydi dışarı çıkalım!");

            Console.ReadLine();
        }
    }

    enum Gunler
    {
        Pazartesi, // Gunler enum unun Pazartesi üyesi ve index i 0.
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
