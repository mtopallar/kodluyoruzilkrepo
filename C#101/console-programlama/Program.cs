using System;

namespace console_programlama
{
    class Program
    {
        //dotnet new console --framework net5.0
        public static void Main(string[] args)
        {
            //default olarak da main metodu public'tir.
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz: ");
            string lastName = Console.ReadLine();
            //Console.WriteLine($"Merhaba {name} {lastName}. Hoşgeldiniz.");
            Console.WriteLine("Merhaba , " + name + " " + lastName);
            Console.ReadKey();
        }
    }
}
