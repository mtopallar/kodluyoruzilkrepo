using System;

namespace recursive_extension_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekurfis (Ozyinelemeli Kendi Kendini Cagiran Fonksiyon) -- Bunun yaptigi isi for gibi donguler ile de yapabiliriz.
            // Us alma, faktoriyel alma gibi islemler en sik kullanildigi alanlardir.
            // 3^4: = 3.3.3.3

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);


            Islemler islemler = new();
            Console.WriteLine(islemler.Expo(3, 4));

            //Extension Metodlar
            string ifade = "Zikriye Urkmez Cengiz";
            // ifade icinde bosluk degeri olup olmadigini bize donen extension yazmak istiyoruz:
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            } 
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            //Test icin kullanildi.
            int test = 0;
            Console.WriteLine(test.CheckIsItConvertable());

            int[] dizi = {9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            //Verilen bir  sayinin cift olup olmadigini kontrol eden extension yazmak istiyoruz.
            // int sayi1 = 5; => false
            int sayi1 = 4; // => true
            Console.WriteLine(sayi1.IsEvenNumber());

            //Verilen string ifadenini ilk karakterini kesip bize getiren extension fonksiyon yazmak istiyoruz:
            string metin = "Zikriye";
            Console.WriteLine(metin.GetFirstCharacter());

            Console.ReadLine();
        }
    }

    class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2) * 3 * 3;
        //Expo(3,1) *3 *3 *3;
        //3 * 3 * 3 * 3 = 3^4 elde etmiş olduk.
    }

    public static class Extensions
    {
        //Extension metodlar static bir class içerisinde static bir metot olarak yazılmalılar.
        //Extension metod birden fazla parametre alabilir ancak tanımlı parametrelerden sadece 1 tanesi ve ilk parametresi this ile tanımlanabilir. 
        //Once metodu extension degil de normal metodmus gibi yaz.
        //Sonra extension hale getirmek icin metodun parametre kismina this keywordunu ekle.
        //CheckSpaces metodu string parametre aliyor ve bu sebeple this keywordu string ifadesinin basina eklenmis oluyor. Bu sebeple CheckSpaces metodu bir string exxtension method oluyor. Alt tarafta test etmek icin yaptigim metod parametre olarak int bir deger aliyor bu sebeple this keywordu int tipinin basina geldi. Bu metod da dogal olarak int bir ifade ile kullanilabilecek bir extension metod olmus oldu. Bu tip her sey olabilir. Sadece primitif tipler degil.
        //Son olarak extension metod  public static bool CheckSpaces(this string param) olarak tanimlanmis olsa da biz bunu kullanirken 
        //ifade.RemoveWhiteSpaces() seklinde kullaniyoruz. Kullanirken tekrar parametre gondermiyoruz .ToString() gibi.
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static bool CheckIsItConvertable(this int deger)
        {
            //Test icin yazildi.
            return true;
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string parametre)
        {
            return parametre.Substring(0,1);
        }
    }
}
