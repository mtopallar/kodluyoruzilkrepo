using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace inde bulunur.
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //İçerisindeki verilere erişmek:
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("**-------------AddRange-------------***");
            string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayilar = new List<int>(){1,3,7,9,92,5};
            liste.AddRange(renkler); //collection tipindeki herşeyi ekleyebiliriz.
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item); // burada AddRange olarak eklediğimiz öğeleri system.generic.array gibi bir array tanımı olarak geçmiyor. renkler veya sayılara da ikinci bir foreach uygulanmış gibi içindekileri direk okuyabiliyoruz.
            }

            //Sort
            Console.WriteLine("********----------------- Sort ------------******");
            //liste.Sort(); // => runtime hatası verir. Çünkü listenin içinde hem int hem string hem char hem bool farklı farklı veri türleri var. Sıralama varsayılan olarak int değer arayan bir fonksiyon. Bu sebeple veri tileri birbiriyle utuşmadığından sıralamada hata verir. Ancak liste içinde uyumlu veri tipi olsa mesela sadece int veri olsa o zaman .Sort() ile sıralama yapılabilir.

            ArrayList sortableList = new ArrayList();
            sortableList.AddRange(sayilar);
            Console.WriteLine("--------- Before Sort --------- ");
            foreach (var item in sortableList)
                Console.WriteLine(item);

            sortableList.Sort();
            Console.WriteLine("--------- After Sort --------- ");
            foreach (var item in sortableList)
                Console.WriteLine(item);

            // Binary Search
            Console.WriteLine("*******--------- Binary Search ------------********");
            //Bir önceki dersimizde elimizdeki renkler listesine sarı rengini binary search yaptığımızda beklenmedik bir şekilde -2 indexini dönmüştü. Bunun sebebi binary search kullanılmadan önce Listenin sıralanması gerektiğindenmiş. Şimdi elimizdeki sıralı veri ile binary search ü yeniden deneyelim:
            Console.WriteLine(sortableList.BinarySearch(92));
            Console.WriteLine(sortableList.BinarySearch(9));

            //Reverse()
            Console.WriteLine("*******--------- Reverse ------------********");
            // Listeyi baştan sonra tortadan aynalama yaparak ters çeviriyordu:
            sortableList.Reverse();
            foreach (var item in sortableList)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("*******--------- Clear() ------------********");
            sortableList.Clear();
            foreach (var item in sortableList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Boş listeyi yazdırma bitti.");
            Console.ReadLine();
        }
    }
}
