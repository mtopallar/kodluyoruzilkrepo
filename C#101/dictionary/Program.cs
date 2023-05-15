using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic name spaceinde bulunur.
            //Verileri key value pair olarak tutarlar. Key ve value nun tiplerini belirtmemiz gerekiyor. Keyler farklı yani unique olmalıdır. Aksi halde runtime hatası alırız.
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>(); //key integer, value string
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //Dizi elemanlarına erişim:
            Console.WriteLine("----------- Elemanlara erişim-----------");
            Console.WriteLine(kullanicilar[12]); // => Ahmet Yılmaz
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item); // => Her bir item [key, value] şeklinde yazılır. isteniirse item.key ya da item.value şeklinde sadece istenen değer de yazdırılabilir.
            }

            //Count
            Console.WriteLine("----------- Count-----------");
            Console.WriteLine(kullanicilar.Count);
            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(12)); // => True
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez")); // => False

            //Remove
            Console.WriteLine("----------- Remove-----------");
            kullanicilar.Remove(12); // => key ile siliyor.
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            // Keys - Values
            Console.WriteLine("---------Keys ---------");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------Values ---------");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
