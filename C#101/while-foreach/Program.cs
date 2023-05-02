using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // Birden baslayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp yazdiran program:
            
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            //'a' dan 'z' ye kadar (z dahil degil) tüm harfleri kconsole a yazdiralim.
            char karakter = 'a';
            while (karakter < 'z')
            {
                Console.Write(karakter);
                karakter++;
            }
            
            Console.WriteLine("\n------------Foreach-------------");

            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
