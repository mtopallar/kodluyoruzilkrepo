using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2; // bellekte 4 byte yer kaplar.
            string degisken = null;
            string Degisken = null; // c# case sensitive'dir.
            //int 3degisken = 0; => degisken isimleri rakamla baslayamaz.
            //string class = ""; => ozel keywordler kullanilamaz.
            //string degisken = ""; => ayni kod blogunda ayni isimli degisken birden fazla kere tanimlanamaz.
            //string isim+soyisim = "" => degisken adinda matematiksel ifade bulunamaz.
            //string degisken adi = "" => degisken adinda bosluk bulunamaz.
            string whiteSpace = " ";
            string emptyString = "";            
            byte byteDegiskeni = 5; //byte bellekte 1 byte lik yer kaplar. 0-255 arasinda deger alabilir.
            sbyte sbyteDegiskeni = 5; //sbyte bellekte 1 byte lik yer kaplar. -128 ile 127 arasinda tamsayi deger alabilir.
            short shortDegiskeni = 5; //bellekte 2 byte yer kaplar. -32,768 ile 32,768 arasinda tamsayi deger alir.
            ushort ushortDegiskeni = 5; //bellekte 2 byte yer kaplar. 0 ile 65,365 arasında tamsayı degerler alir.

            Int16 int16Degiskeni = 2; // bellekte 2 byte yer kaplar.
            Int32 int32Degiskeni = 5; // bellekte 4 byte yer kaplar.
            Int64 int64Degiskeni = 5; // bellekte 8 byte yer kaplar.

            uint uintDegiskeni = 2; // bellekte 4 byte yer kaplar.
            long longDegiskeni = 4; // bellekte 8 byte yer kaplar. tamsayi degerler tutar.
            ulong ulongDegiskeni = 4; // bellekte 8 byte yer kaplar.

            float floatDegiskeni = 0; // reel sayı da tutabilir. 4 byte yer kaplar.
            double doubleDegiskeni = 0; // reel sayı da tutabilir. 8 byte yer kaplar.
            decimal decimalDegiskeni = 0; // reel sayı da tutabilir. 16 byte yer kaplar.

            char charDegiskeni = 'a'; // bellekte 2 byte yer kaplar.
            string stringDegiskeni = "Zikriye"; // bellekte kapladigi alan icin bir sinir yoktur.

            bool boolDegiskeni = true;

            DateTime dateTime = DateTime.Now; // tarihsel veri tutmak icin kulanilir. (Now o anin tarih bilgisini verir.)

            object objectDegiskeni = "x";
            object objectDegiskeni2 = 'y';
            object objectDegiskeni3 = 16;
            object objectDegiskeni4 = 16.4;

            //string ifadeler
            string stringDeger = String.Empty;
            stringDeger = "Zikriye Urkmez";
            string ad = "Zikriye";
            string soyad = "Urkmez";
            string adSoyad = ad + " " + soyad;

            //integer tanimlama sekilleri
            int intDeger1 = 5;
            int intDeger2 = 3;
            int carpim = intDeger1 * intDeger2;

            //bool ifadeler
            bool mantiksalDeger = 10<2; // mantiksalDeger degiskenine false degeri atayacaktir.
            
            //Degisken Donusumleri
            string string20 = "20";
            int int20 = 20;
            string stringToplama = string20 + int20.ToString();
            Console.WriteLine(stringToplama); // 2020

            int convertedInt = int20 + Convert.ToInt32(string20);
            Console.WriteLine(convertedInt); // 40


            int intWithParse = int20 + int.Parse(string20); //Parse string bir ifadeden dönüşüm icin kullanilir.
            Console.WriteLine($"Parsed: {intWithParse}"); //Parsed: 40

            //DateTime to String donusumleri
            string dateTimeToString = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTimeToString);

            string dateTimeToStringWithSlash = DateTime.Now.ToString("dd\\/MM\\/yyyy"); // iki adet ters slash bolge ayarlarini gormezden gelip belirttigim formatta cikti almak istedigimi belirtmek icin.
            Console.WriteLine(dateTimeToStringWithSlash);

            string hourToString = DateTime.Now.ToString("HH:mm"); 
            Console.WriteLine(hourToString);
            Console.ReadKey();
        }
    }
}
