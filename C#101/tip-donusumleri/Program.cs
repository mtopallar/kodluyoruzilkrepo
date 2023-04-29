using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilincsiz Donusum)
            // Dusuk kapasiteli bir degiskenin kendinden yuksek kapasiteli bir degiskene otomatik atanmasidir. Parse, convert gibi komutar gerektirmeden kendiliginden nolur.

            byte byteA = 5;
            sbyte sbyteB = 30;
            short shortC = 10;

            int intD = byteA+sbyteB+shortC; //int yukaridaki tum degiskenlerden daha fazla kapasiteye sahiptir. Eger burada bir kapasite uyumsuzlugu olsaydi bu atama islemi gerceklesmezdi.
            Console.WriteLine("intD: " + intD);

            long longE = intD;
            Console.WriteLine("longE: " + longE);

            float floatF = longE;
            Console.WriteLine("floatF :" + floatF);

            string stringF = "zikriye";
            char charG = 'k';

            object objectH = stringF + charG + intD;
            Console.WriteLine("objectH : " + objectH);

            //Explicit Conversion (Bilincli Donusum)
            //C# ın kendi kendine yapamadigi, bizim bilincli bir sekilde yaptigimiz donusumlerdir.
            // parse, convert.to, toString...
            Console.WriteLine("**********Explicit Conversion**************");
            int intX = 4;
            // byte byteY = intX; => bu sekilde donusturme hata verir. Cunku int byte dan daha genis bir araliga sahiptir. Ancak biz ilgili deger için byte in da int in de sorun cikartmayacagindan eminsek (mesela 4 rakamii int icin de byte icin de sorunsuzca tutulabilir) su sekilde cast edebiliriz:
            byte byteY = (byte)intX;
            Console.WriteLine("byteY : " + byteY);

            int intZ = 100;
            byte byteT = (byte)intZ;
            Console.WriteLine("byteT : " + byteT);

            float floatW = 10.3f;
            byte byteV = (byte)floatW; // 10.3 u 10 a yuvarlamis oldu.
            Console.WriteLine("byteV : " + byteV);

            //ToString Metodu
            Console.WriteLine("********ToString()*************");
            int doubleX = 6;
            string doubleY = doubleX.ToString();
            Console.WriteLine("doubleY: " + doubleY);

            string doubleZ = 12.5f.ToString();
            Console.WriteLine("doubleZ : " + doubleZ);

            //System.Convert.To...
            Console.WriteLine("***********System.Convert**********");

            string string1 = "10", string2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(string1);
            sayi2 = Convert.ToInt32(string2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam : " + toplam);

            //Parse
            Console.WriteLine("********Parse Methodu***********");
            ParseMethod();

            Console.ReadKey();
        }

        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1); // Parse string ifadelerden rakamsal ifadelere donusum icin kullanilir. Her zaman string alir.
            Console.WriteLine("rakam1 : " + rakam1);

            double1 = Double.Parse(metin2);
            Console.WriteLine("double1 : " + double1);

            string stringDate = "24.04.2023";
            DateTime parsedDate = DateTime.Parse(stringDate);            
            Console.WriteLine(parsedDate);
        }
    }
}
