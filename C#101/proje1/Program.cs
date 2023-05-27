using System;
using System.Collections.Generic;

namespace proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonRehberiManager telefonRehberiManager = new TelefonRehberiManager();

            Console.WriteLine("Lütfen yapmaz istediğiniz işlemi seçiniz:");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            if (int.TryParse(Console.ReadLine(), out int kullaniciSecimi) || kullaniciSecimi! < 0 || kullaniciSecimi! > 5)
            {
                switch (kullaniciSecimi)
                {
                    case 1:
                        telefonRehberiManager.Ekle(new TelefonRehberi
                        {
                            Name = telefonRehberiManager.AdBilgisiAl(),
                            LastName = telefonRehberiManager.SoyadBilgisiAl(),
                            PhoneNumber = telefonRehberiManager.TelefonBilgisiAl()
                        }
                        );
                        break;
                    case 2:
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin ad yada soyadını giriniz:");
                        telefonRehberiManager.Sil(telefonRehberiManager.AdBilgisiAl("İsim: "), telefonRehberiManager.SoyadBilgisiAl("Soyisim: "));
                        break;
                    case 3:
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        telefonRehberiManager.NumarayiGuncelle(telefonRehberiManager.AdBilgisiAl("İsim: "), telefonRehberiManager.SoyadBilgisiAl("Soyisim: "));
                        break;
                    case 4:
                        Console.WriteLine("Sıralama seçiminizi yapınız:");
                        Console.WriteLine("A-Z : (1)");
                        Console.WriteLine("Z-A : (2)");
                        if (int.TryParse(Console.ReadLine(), out int siralama))
                        {
                            Console.WriteLine("Telefon Rehberi");
                            Console.WriteLine("*************************************");
                            if (siralama == 1)
                            {
                                ListeyiKonsolaYazdir(telefonRehberiManager.TumListeyiGetirAlfabetik());////
                                var list = telefonRehberiManager.TumListeyiGetirAlfabetik();
                                foreach (var rehber in list)
                                {
                                    Console.WriteLine($"İsim: {rehber.Name}, Soyisim: {rehber.LastName}, Telefon Numarası: {rehber.PhoneNumber}");
                                }
                            }
                            else if (siralama == 2)
                            {
                                var list = telefonRehberiManager.TumListeyiGetirReversed();
                                foreach (var rehber in list)
                                {
                                    Console.WriteLine($"İsim: {rehber.Name}, Soyisim: {rehber.LastName}, Telefon Numarası: {rehber.PhoneNumber}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız.");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
                        Console.WriteLine("*************************************");
                        Console.WriteLine("İsim ve soyisme göre arama yapmak için       : (1)");
                        Console.WriteLine("Telefon numarasına göre arama yapmak için    : (2)");
                        if (int.TryParse(Console.ReadLine(), out int secim) && secim == 1 || secim == 2)
                            if (secim == 1)
                            {
                                DetaylariYazdir(telefonRehberiManager.IsmeGoreGetir(telefonRehberiManager.AdBilgisiAl("Aranacak ismi giriniz:")));
                            }
                            else if (secim == 2)
                            {
                                DetaylariYazdir(telefonRehberiManager.NumarayaGoreGetir(telefonRehberiManager.TelefonBilgisiAl()));
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim yaptınız.");
                            }
                        break;
                }
            }
            else
                Console.WriteLine("Hatalı Seçim Yaptınız");



            Console.ReadLine();
        }

        private static void ListeyiKonsolaYazdir(List<TelefonRehberi> rehberListesi)
        {
            foreach (var rehber in rehberListesi)
            {
                Console.WriteLine($"İsim: {rehber.Name}, Soyisim: {rehber.LastName}, Telefon Numarası: {rehber.PhoneNumber}");
            }
        }

        private static void DetaylariYazdir(TelefonRehberi telefonRehberi)
        {
            if(telefonRehberi is not null)
            {
                Console.WriteLine($"İsim: {telefonRehberi.Name}, Soyisim: {telefonRehberi.LastName}, Telefon Numarası: {telefonRehberi.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Aranılan kriterde kayıt bulunmamaktadır.");
            }
        }
    }
}
