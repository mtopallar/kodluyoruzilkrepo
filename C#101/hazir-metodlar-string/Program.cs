using System;

namespace hazir_metodlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";
            string degisken3 = "dersimiz CSharp, Hoşgeldiniz!";
            string degisken4 = "CSharp";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUppper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!")); //değişken ile Merhaba yı birleştirmiş gibi davranır.

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //birinci değişken karakter sayısı olarak ikinci değişkene eşit olursa condition bize 0 döndürür. Birinci değişken ikinciden daha büyük ise bize 1; ikinci birden daha büyük ise -1 döner.
            Console.WriteLine(String.Compare(degisken,degisken3,true)); //birinci değişken , ikinci değişken, ignore case yani büyük küçük harfi önemsememe durumu. (true dersek case insensitive, false dersek case sensitive olur) => 0
            Console.WriteLine(String.Compare(degisken,degisken3,false)); // => 1

            //Contains
            Console.WriteLine(degisken.Contains(degisken4)); //degisken içerisinde değişken4 var mı? => true
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // =>true
            Console.WriteLine(degisken.StartsWith("Selam")); // => false

            //IndexOf()
            Console.WriteLine(degisken.IndexOf("CS")); //burada C nin indexini döner yani ilk indexi veriyor (tabi varsa) Yoksa -1 döner.
            Console.WriteLine(degisken.IndexOf("Zikriye"));  // => -1

            //LastIndexOf()
            Console.WriteLine(degisken.LastIndexOf("i"));  // i nin en sondaki indexini getirir.

            //Insert
            Console.WriteLine(degisken.Insert(0,"Bunu ekle!")); // 0. indexten başlayarak verdiğimiz ifadeyi ilgili değişkene ekler.

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //değişken2 nin sol yanına 30 a tamamlayacak kadar boşluk (veya belirtilen bir karakter) ekler. CSS den bildiğimiz padding left gibi ancak tek farkı değişken2 + padding = 30 oluyor. eğer değişken2 tek başına 30 dan büyük ise burada hiç padding eklenmez.
            Console.WriteLine(degisken + degisken2.PadRight(50,'*'));

            //Remove()
            Console.WriteLine(degisken.Remove(10)); // 10.indexten başlayarak sonuna kadar siler.
            Console.WriteLine(degisken.Remove(5,3)); // 5.indexten başlayarak 3 karakter siler.

            //Replace()
            Console.WriteLine(degisken.Replace("CSharp", "C#")); //Metin içindeki CSharp ifadesini C# olarak değiştirir.
            Console.WriteLine(degisken.Replace(" ", "*")); //Metin içindeki boşlukları * ile değiştirir.

            //Split()
            Console.WriteLine(degisken.Split(' ')[1]); // değişken i boşluk karakterlerinden parçalayarak bir dizi oluşturur ve o dizinin 1 indexteki elemanını getirir.

            //Substring()
            Console.WriteLine(degisken.Substring(4)); // 4.indexten başlayarak cümlenin sonuna kadar getirir.
            Console.WriteLine(degisken.Substring(4,6)); // 4.indexten başlayarak 6 karakter getirir.

            Console.ReadLine();
        }
    }
}
