using System;

namespace polymorphism_sealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                                        Canlılar
                                           |
                           Bitkiler                  Hayvanlar
                        |           |             |            |
                     Tohumlu     Tohumsuz    Sürüngenler     Kuşlar

            */

            //Sealed anahtar kelimesi class lar ile birlikte kullanılır. Eğer bir sınıfın başka sınıflar tarafından türetilmesini engellemek istiyorsak yani kalıtım vermesini engellemek istiyorsak bunu sealed anahtar kelimesi ile yaparız. Örn public sealed class Canlilar şeklinde tanımlanır ve eğer bunu yaparsak canlılardan kalıtım alan diğer sınıflar hata verirken, canlılar sınıfındaki protected varlıklar için de kırmızı değil sayı uyarı çıkar ve protected tanımladın ama kalıtım veremeyeceği için gereksiz oldu gibi bir uyarıda bulunur bize.

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            // tohumluBitki.Beslenme();
            // tohumluBitki.Solunum();
            // tohumluBitki.Bosaltim();
            //tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("********************");

            Kuslar marti = new Kuslar();
            // marti.Solunum();
            // marti.Beslenme();
            // marti.Bosaltim();
            //marti.Adaptasyon();
            marti.Ucmak();

            Console.ReadLine();
        }
    }
}
