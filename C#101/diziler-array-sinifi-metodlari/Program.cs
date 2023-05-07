using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort => siralama
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            
            Console.WriteLine("--------- Sirasiz Liste ---------");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("--------- Sirali Liste ---------");
            Array.Sort(sayiDizisi); //void fonksiyon, dizinin kendisini direk duzenler.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear verdigimiz dizi icerisinde, verdigimiz indexten baslayarak, verdigimiz sayida elemani sifirlamaya yarar. Clear metodu veriyi silmez. Ilgili dizinin veri tipinin varsayilan veri tipini atar. int icin 0, string icin null gibi.
            Console.WriteLine("--------- Array Clear ---------");
            Array.Clear(sayiDizisi,2,2); //dizi: sayiDizisi baslangic: 2.index kacElemanIcın: 2
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("--------- Array Reverse ---------");
            //Reverse => verdigimiz diziyi ortadan itibaren ayna yansimasi gibi yer degistiriyor. Sonuc olarak arrayi ters cevirmis oluyor.
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf => verdigimiz dizi icerisinde, verilen elemanin (varsa) dizideki index numarasini verir. Yoksa -1 verir.
            Console.WriteLine("--------- Array IndexOf() ---------");
            int indexNumarasi = Array.IndexOf(sayiDizisi,23); //sayiDizisi icinde 23 numarali eleman kacinci indexte?
            Console.WriteLine($"Index Numarasi : {indexNumarasi}");

            //Resize, diziyi yeniden boyutlandirir.
            Console.WriteLine("--------- Array Resize() ---------");
            Array.Resize<int>(ref sayiDizisi,9); //<ilgili dizinin veritipi>(referans yenidenBoyutlandirilacakDİzi, yeniBoyut) buradaki yeni boyut eleman sayisi cinsinden index olarak degil.
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //3 elemanlı integer bir dizi resize edilip yeni boyutu 10 olarak verilirse ve buralara bir deger atamasi yapilmazsa oralara int in default degeri olan 0 atamasi otomatik olarak yapilir. Resize ile dizi buyutulebilecegi gibi, kisaltmak icin de kullanilabilir. de.            
        }
    }
}
