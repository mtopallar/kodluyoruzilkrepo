using System;

namespace kurucu_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Söz dizimi
                class SinifAdi
                    {
                        [Erişim belirteci] [Veri tipi] ÖzellikAdı;
                        [Erişim belirteci] [Geri dönüş tipi] MetodAdi(Parametre Listesi)
                        {
                            Metod komutları
                        }
                    }
            */

            /*
            Erişim Belirteçleri:
            * Public => herhangi bir yerden erişilebilir.
            * Private => sadece tanımlandığı sınıf içerisinden erişilebilir.
            * Internal => sadece kendi bulunduğu proje içerisinden erişilebilir.
            * Protected => sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan diğer sınıflar tarafından erişilebilir.
            */

            Console.WriteLine("Çalışan 1:");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23415634,"İnsan Kaynakları");
            //calisan1.Ad = "Ayşe";
            //calisan1.Soyad = "Kara";
            //calisan1.No = 23415634;
            //calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("******************");

            Console.WriteLine("Çalışan 2:");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("******************");

            Console.WriteLine("Çalışan 3:");
            Calisan calisan3 = new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

         public Calisan(string ad, string soyad, int no, string departman)
        {
            // erişim belirteci public olmak zorundadır.
            // geri dönüş tipi yoktur. (void de değildir hiç yazılmaz)
            // constructor metodun ismi sınıf ismi ile aynı olmak zorundadır.
            // parametreli ctor.
            Ad = ad; // veya this.Ad = ad
            Soyad = soyad;
            No = no;
            Departman = departman;
        }

         public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public Calisan()
        {
            // parametresiz ctor. Yani ctor metodlar da overload edilebilir.
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }
    }
}
