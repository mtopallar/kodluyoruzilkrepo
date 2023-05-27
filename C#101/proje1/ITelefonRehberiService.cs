using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje1
{
    public interface ITelefonRehberiService
    {
        List<TelefonRehberi> OntanimliListeyiGetir();
        TelefonRehberi IsmeGoreGetir(string aranacakAd);
        List<TelefonRehberi> TumListeyiGetirAlfabetik();
        List<TelefonRehberi> TumListeyiGetirReversed();
        TelefonRehberi NumarayaGoreGetir(string numara);
        void Ekle(TelefonRehberi telefonRehberi);
        void NumarayiGuncelle(string oldNumber, string newNumber);
        void Sil(string ad, string soyad);
        string AdBilgisiAl(string message = null);
        string SoyadBilgisiAl(string message = null);
        string TelefonBilgisiAl(string message = null);

    }
}