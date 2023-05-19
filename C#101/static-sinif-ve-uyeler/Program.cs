using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi); //burada static olan ctor ile erişim olduğu için çalışır.
            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK"); // burada ise static ctor bir daha çalışmaz normal ctor çalışır.
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(400, 50));

            /*
            Notlar:
            => static classlar içinde static olmayan herhangi bir üye kullanılamaz.
            => Islemler islemler = new Islemler(); static class lar new lenmez. Direk class adı ile kullanılır. Static olmayan class ın static fieldlarına erişim de yine class adı. field ya da metod adı şeklinde olur.
            => Static sınıflara kalıtım işlemi uygulanamaz.
            => Bir sınıfın static olmayan özellikleri oluştulan her yeni instance a özgü yani her bir instance ile verilen değer olarak set ediliyorken (örneğin Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK"); satırında calisan isimli instance ın ad, soyan ve departman özellikleri Ayşe Yılmaz IK olarak verilmiş. Yeni bir instace oluşturduğumuzda biz ne verirsek o olacak yani her instance kendine özgü değerler ile oluşacak.) static olan özellikler ise her bir instance a değil de sınıfa özgüymüş gibi hareket edecek. Yani Calisan class ından istediğimiz kadar instance oluşturalım. Her birinin adıi soyadı ve departman değerleri değişik olacakken Çalışan sayısı özelliği Calisan class ı new lendiğinde sıfırlanmayacak. Kaldığı yerden devam edecek :)
            => (Ders sayfasından) Normal sınıflar içerisinde static metotlar ve üyeler kullanabiliriz. Peki o halde neden sınıfları static yapma ihtiyacımız olsun? Buna okunabilirliği arttırmak için diyebiliriz. Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.
            */

            BaskaClass baskaClass = new BaskaClass(); // Benim test classım.
            baskaClass.CalisanSayisiMetodu();

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
            //static ctorların erişim belirteçleri olmaz.
            //Static ctor sadece bir kere çalışır o da Calisan sınıfına ilk erişildiğinde. Ancak normal ctor her yeni new de çalışır.
            // Ancak bu durum bir class ın sataic bir özelliği sadece static ctor ile atanır olarak algılanmasın. Yukarıda 9 numaralı satırı iptal etsek de Calisan class ı new lenirken de önce static metod çalışarak bu değeri set edebilir. Hatta static ctor u iptal etsek bile normal ctor içinden buradaki private static int _calisanSayisi; field ını set edebilir veya hali hazırda olduğu gibi artırabiliriz.
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
