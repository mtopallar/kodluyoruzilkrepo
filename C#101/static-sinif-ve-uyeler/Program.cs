using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not: static classlar içinde static olmayan herhangi bir üye kullanılamaz.
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            BaskaClass baskaClass = new BaskaClass(); // Benim test classım.
            baskaClass.CalisanSayisiMetodu();

            //Islemler islemler = new Islemler(); static class lar new lenmez. Direk class adı ile kullanılır. Static olmayan class ın static fieldlarına erişim de yine class adı. fiel ya da metod adı şeklinde olur.
            //Static sınıflara kalıtım işlemi uygulanamaz.

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(400,50));

            Console.ReadLine();
        }
    }

    class Calisan
    {
        private static int _calisanSayisi;
        public static int CalisanSayisi { get => _calisanSayisi; }

        private string _isim;
        private string _soyIsım;
        private string _departman;

        static Calisan()
        {
            //static ctorların erişim belirteçleri olmaz. Static ctor sadece bir kere çalışır o da Calisan sınıfına ilk erişildiğinde. Ancak normal ctor her yeni new de çalışır.
            _calisanSayisi = 0;
        }

        public Calisan(string isim, string soyIsım, string departman)
        {
            _isim = isim;
            _soyIsım = soyIsım;
            _departman = departman;
            _calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

         public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }


    class BaskaClass
    {
        // Bu benim test class ım. Farklı bir class içindeki farklı bir metoddan bile erişilse de Calisan classının static olan calisan sayısı field ı statik olduğu için aynı değeri dönüyor.
        public void CalisanSayisiMetodu()
        {
            Console.WriteLine("Çalışan sayısı class newlenmedi: {0}", Calisan.CalisanSayisi);
        }
    }
}
