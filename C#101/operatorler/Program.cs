using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve islemli atama:
            int x = 3;
            int y = 4;
            y = y+2;
            x += 3; //islemli atama
            Console.WriteLine($"x:{x}, Y:{y}");
            y /= 3;
            x *= 2;

            Console.WriteLine($"x:{x}, Y:{y}");

            // Mantıksal Operatorler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) // iki kosul da saglanmali
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted) //iki kosuldan biri saglansa yeterli
                Console.WriteLine("Great!");
            
            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");
            
            //İliskisel Operatorler
            // <, >, <=, >=, ==, !=

            int birinciDeger = 3;
            int ikinciDeger = 4;

            bool sonuc = birinciDeger < ikinciDeger;
            Console.WriteLine(sonuc);

            sonuc = birinciDeger > ikinciDeger;
            Console.WriteLine(sonuc);
            
            sonuc = birinciDeger >= ikinciDeger;
            Console.WriteLine(sonuc);

            sonuc = birinciDeger <= ikinciDeger;
            Console.WriteLine(sonuc);

            sonuc = birinciDeger == ikinciDeger;
            Console.WriteLine(sonuc);

            sonuc = birinciDeger != ikinciDeger;
            Console.WriteLine(sonuc);

            //Aritmetik Operatorler
            // /, *, +, -, %

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            //sayi1++;
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);


            Console.ReadKey();
        }
    }
}
