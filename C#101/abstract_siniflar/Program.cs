using System;

namespace abstract_siniflar
{
    class Program
    {
        /*
        => Abstract sınıflar new anahtar kelimesi ile türetilemezler.
        => Sadece metod imzası barındırabilir ya da override edilen metodlar içerebilir. Abstract metodlar inherit edildiği yerde override edilerek yazılmak zorundadır. (Tıpkı interfacelerdeki her metodun ipmlemente edilmesi zorunluluğu gibi)
        => Abstract bir sınıftır bu sebeple interfacelerin aksine abstract sınıflar sadece 1 kere inherit edilebilir.
        */
        static void Main(string[] args)
        {
            Focus focus = new();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("\n************************\n");

            Civic civic = new();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("\n************************\n");

            NewFocus newFocus = new();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            Console.WriteLine("\n************************\n");

            NewCivic newCivic = new();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());



            Console.ReadLine();
        }
    }
}
