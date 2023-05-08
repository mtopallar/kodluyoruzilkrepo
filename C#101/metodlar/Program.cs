using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodlar class icerisine yazilir. Erisilecek olan yer ile metodun bulundugu class ayni ise metodu direk adi ile cagirabiliriz. Ancak metod farkli bir class icinde ise class adi.metodAdi (statik ise) seklinde erisim gerekebilir. (statik degilse class in instance ini olusturmak gerekir.)

            //erisimBelirteci geriDonusTipi metodAdi(varsa parametreler(argumanlar))
            //{
                // komutlar.
                //return (void olmayan bunu geri don dedigimiz komut)
            //}
            //Main static bir metod oldugu icin Topla metoduna Main icinden erisebilmek icin Topla metodunu da static olarak isaretlemeliyiz.
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metodlar metodlar = new Metodlar();
            metodlar.EkranaYazdir(Convert.ToString(sonuc));

            
            int sonuc2 = metodlar.ArttirVeTopla(a,b);
            metodlar.EkranaYazdir(sonuc2.ToString()); // 7
            metodlar.EkranaYazdir((a+b).ToString()); // 5

            int sonuc3 = metodlar.ArttirVeToplaRef(ref a, ref b);
            metodlar.EkranaYazdir(sonuc3.ToString()); // 7
            metodlar.EkranaYazdir((a+b).ToString());  // 7

            Console.ReadKey();
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

    }

    class Metodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 +=1;
            return(deger1+deger2);
        }

        public int ArttirVeToplaRef(ref int deger1, ref int deger2)
        {
            //burada degiskenlerin kendilerini degil bellekteki referanslarini aliyoruz. Deger tip degil de referans tip gibi hareket edecek. Bir baska deyisle kopyalari uzerinde degil de degiskenlerin kendileri ile direk islem yapacak.
            deger1 += 1;
            deger2 +=1;
            return(deger1+deger2);
        }
    }
}
