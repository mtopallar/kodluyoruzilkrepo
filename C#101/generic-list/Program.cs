using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T => Generic (oject türünde)

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count (eleman sayısı)
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            //Foreach ve List.ForEaah ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden Eleman Çıkarma:
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0); // sıfırıncı indexteki elemanı sayiListesinden çıkar.
            renkListesi.RemoveAt(1); // Birinci indexteki elemanı renkListesi listesinden çıkar.

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste İçerisinde Arama:
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu.");

            //Elemanın indexine erişme

            //Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            Console.WriteLine(renkListesi.IndexOf("Sarı"));

            //Diziyi Listeye Çevirmek
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Tüm listeyi temizleme
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.SoyIsim = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Özcan";
            kullanici2.SoyIsim = "Çalışkan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                SoyIsim = "Arda",
                Yas = 24
            });

            foreach (Kullanicilar kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı : " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + kullanici.SoyIsim);
                Console.WriteLine("Kullanıcı yaşı : " + kullanici.Yas);
            }

            yeniListe.Clear();

            Console.ReadLine();
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyIsim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
