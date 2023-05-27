using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje1
{
    public class TelefonRehberiManager : ITelefonRehberiService
    {
        public List<TelefonRehberi> telefonRehberListesi;

        public TelefonRehberiManager()
        {
            if (telefonRehberListesi is null)
                telefonRehberListesi = OntanimliListeyiGetir();
        }

        public TelefonRehberi IsmeGoreGetir(string aranacakAd)
        {
            return telefonRehberListesi.FirstOrDefault(x => x.Name == aranacakAd || x.LastName == aranacakAd);
        }

        public List<TelefonRehberi> TumListeyiGetirAlfabetik()
        {
            return telefonRehberListesi.OrderBy(x=> x.Name).ToList();
        }

        public List<TelefonRehberi> TumListeyiGetirReversed()
        {
            return telefonRehberListesi.OrderByDescending(x=> x.Name).ToList();
        }

        public void Ekle(TelefonRehberi telefonRehberi)
        {
            telefonRehberListesi.Add(telefonRehberi);
            Console.WriteLine("Rehbere ekleme başarılı");
        }

        public TelefonRehberi NumarayaGoreGetir(string numara)
        {
            return telefonRehberListesi.FirstOrDefault(x => x.PhoneNumber == numara);
        }

        public void NumarayiGuncelle(string ad, string soyad)
        {
            var mevcutRehber = telefonRehberListesi.FirstOrDefault(x => x.Name == ad || x.LastName == soyad);
            if (mevcutRehber is not null)
            {
                mevcutRehber.PhoneNumber = TelefonBilgisiAl("Yeni telefon numarası: ");
                Console.WriteLine("Güncelleme başarılı");
            }
            else
            {
                if (SecimiUygula(IslemAdi.Guncelleme.ToString(), out int secim))
                {
                    switch (secim)
                    {
                        case 1:
                            return;
                        case 2:
                            NumarayiGuncelle(AdBilgisiAl(), SoyadBilgisiAl());
                            break;
                    }
                }
            }
        }

        public List<TelefonRehberi> OntanimliListeyiGetir()
        {
            List<TelefonRehberi> onTanimliList = new List<TelefonRehberi>()
            {
                new TelefonRehberi{Name="Dario",LastName = "Abernathy", PhoneNumber="623-782-3977"},
                new TelefonRehberi{Name="Carleton", LastName = "Price", PhoneNumber = "317-552-8089"},
                new TelefonRehberi{Name = "Belle", LastName = "Ernser", PhoneNumber = "431-331-1903"},
                new TelefonRehberi{Name = "Josefina", LastName = "Funk", PhoneNumber = "825-570-1419"},
                new TelefonRehberi{Name = "Tavares",LastName = "Fay", PhoneNumber = "490-389-4993"}
            };
            return onTanimliList;
        }

        public void Sil(string ad, string soyad)
        {
            var getUser = telefonRehberListesi.FirstOrDefault(x => x.Name == ad || x.LastName == soyad);
            if (getUser is not null)
            {
                Console.WriteLine("{0} {1} isimli kullanıcı silinmek üzere, onaylıyor musunuz?(y/n)", ad, soyad);
                var pressedKey = Console.ReadKey();
                if (pressedKey.KeyChar == 'y')
                {
                    telefonRehberListesi.Remove(getUser);
                    Console.WriteLine("Silme işlemi başarılı.");
                }
                else
                    Console.WriteLine("Kullanıcı isteğiyle iptal edildi.");
            }
            else
            {
                if (SecimiUygula(IslemAdi.Silme.ToString(), out int secim))
                {
                    switch (secim)
                    {
                        case 1:
                            return;
                        case 2:
                            Sil(AdBilgisiAl(), SoyadBilgisiAl());
                            break;
                    }
                }
            }
        }

        public string AdBilgisiAl(string message = null)
        {
            if (message is null)
                Console.Write("Lütfen isim giriniz             : ");
            else
                Console.Write(message);
            var name = Console.ReadLine();
            return name;
        }
        public string SoyadBilgisiAl(string message = null)
        {
            if (message is null)
                Console.Write("Lütfen soyisim giriniz          : ");
            else
                Console.Write(message);
            var lastName = Console.ReadLine();
            return lastName;
        }
        public string TelefonBilgisiAl(string message = null)
        {
            if (message is null)
                Console.Write("Lütfen telefon numarası giriniz : ");
            else
                Console.Write(message);
            var number = Console.ReadLine();
            return number;
        }

        private bool SecimiUygula(string islemAdi, out int selectionNumber)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine($"{islemAdi} işlemini sonlandırmak için       :(1)");
            Console.WriteLine("Yeniden denemek için                      :(2)");
            if (int.TryParse(Console.ReadLine(), out selectionNumber) && selectionNumber == 1 || selectionNumber == 2)
                return true;
            Console.WriteLine("Hatalı seçim...");
            return false;
        }
    }
}