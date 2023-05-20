using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            => struct lar da class gibi tanımlanabilir. Kendi ctor ları ve property / field ları olabilir.
            => struct lar değer tipler grubundadır.
            => structlar değer tip olduğu için belleğin stack bölgesinde tutulur ve bu daha hızlı bir aksiyona neden olur. Uzmanlar 16 byte a kadarki verileri srtuct ile bunun üzerindeki verileri class ile tutmayı öneriyorlarmış.

            Ders sayfasından notlar:
            => Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
            => Diğer struct ya da sınıflardan kalıtım almazlar.
            => Interface'lerden kalıtım alabilirler.
            => new anahtar sözcüğü ile nesneleri yaratılabilir.
            => Sınıflar gibi metot, property ve field'lardan oluşurlar.
            => Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
            => Static üye barındırabilirler.
            */
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class alan hesabı {0}", dikdortgen.AlanHesapla());

            DikdortgenStruct dikdortgenStruct = new DikdortgenStruct();
            dikdortgenStruct.KisaKenar = 3;
            dikdortgenStruct.UzunKenar = 4;
            Console.WriteLine("Struct alan hesabı {0}", dikdortgenStruct.AlanHesapla());

            //structların classlardan bir farklı bir örneğini newlemeden direk oluşturabiliyoruz. Ancak bu durumda eğer fieldlara bir değer atamadıysak new leme olmadığı için default değerler atanamaz. Oysa class da arka planda mutlaka bir ctor çalıştığı için default değerler değişken tiplerine göre atanmış olur.
            DikdortgenStruct dikdortgenStructNewsiz;
            dikdortgenStructNewsiz.KisaKenar = 3;
            dikdortgenStructNewsiz.UzunKenar = 4;
            Console.WriteLine("Struct-Newsiz alan hesabı {0}", dikdortgenStructNewsiz.AlanHesapla());

            Console.ReadLine();
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
    struct DikdortgenStruct
    {
        public int KisaKenar;
        public int UzunKenar;

        public DikdortgenStruct(int kisaKenar, int uzunKenar)
        {
            //Parametresiz struct ctor u oluşturma konusunda C# 10'un altındaki sürümlerde buna kızardı ama 10 ve üzeri için bunun mümkün olduğu yazıyor. Ama parametreli ctor da sorun C# 10 un altında da sorun yok. Tabi parametreli ctro kullanıldığında parametre gönderebilmek için struct ı new leyip parametreyi göndermemiz gerek.
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

    }
}
