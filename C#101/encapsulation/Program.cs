using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ogrenci ogrenci = new Ogrenci();
            // ogrenci.Isim = "Ayşe";
            // ogrenci.SoyIsim = "Yılmaz";
            // ogrenci.OgrenciNo = 293;
            // ogrenci.Sinif = 3;
            // ogrenci.OgrenciBİlgileriniGetir();
            // ogrenci.SinifAtlat();
            // ogrenci.OgrenciBİlgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.OgrenciBİlgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBİlgileriniGetir();

            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private string _isim;
        private string _soyIsim;
        private int _ogrenciNo;
        private int _sinif;

        public string Isim
        {
            get { return _isim; }
            set { _isim = value; }
        }
        public string SoyIsim { get => _soyIsim; set => _soyIsim = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif
        {
            get { return _sinif; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf 1 den küçük olamaz.");
                    _sinif = 1;
                }
                else
                    _sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyIsim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void OgrenciBİlgileriniGetir()
        {
            Console.WriteLine("********** Öğrenci Bİlgileri **************");
            Console.WriteLine("Öğrenci adı      :{0}", this._isim);
            Console.WriteLine("Öğrenci soyadı   :{0}", this._soyIsim);
            Console.WriteLine("Öğrenci no       :{0}", this._ogrenciNo);
            Console.WriteLine("Öğrenci sınıfı   :{0}", this._sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
