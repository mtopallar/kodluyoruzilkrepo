using System;

namespace for_loop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //For, while, foreach donguleri mevcut.
            //Ekrandan girilen sayıya kadar olan tek sayilari birden daslayarak ekrana yazdir.
            Console.Write("Lütfen bir sayi giriniz:"); //WriteLine yazdıktan soanra alt satira geciyor. Write ise ayni satirda kaliyor.
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                //komutlar                
            }  

            //1 ile 1000 arasındaki tek ile cift sayilarin toplamlarini ayri ayri hesaplayip yazan program:
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else{
                    tekToplam += i;
                }
            }
            Console.WriteLine($"Tek sayilar toplami: {tekToplam}, çift sayilar toplami: {ciftToplam}");
            // bir duruma bagli olarak donguden cikmak icin break keyword u kullaniriz. Break sadece icinde bulundugu donguyu bitirir.Yani ic ise donguler kullaniyorsak ve en icteki dongude bir break keywordu varsa, disdaki donguler donmeye devam eder.
            // bir durumu atlamak yani o kosul icin iterasyonu (o scyle i) bir ileriye tasimak icin ise continue keyword u nu kullaniriz.

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i); //ciktisi => 1,2,3 olur
            }
            Console.WriteLine("------------------");
             for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i); // => ciktisi 1,2,3,5,6,7,8,9 olur.
            }
            // for (;;)
            // {
            //     // infinite loop
            // }

            Console.ReadLine();
        }
    }
}
