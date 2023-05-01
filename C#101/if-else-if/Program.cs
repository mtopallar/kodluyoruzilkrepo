using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >= 6 && time < 11)
                Console.WriteLine("Gunaydin");
            else if (time <= 18)            
                Console.WriteLine("Iyi gunler");
            else
                Console.WriteLine("Iyi geceler");
            
            string sonuc = time <=18 ? "Iyi Gunler" : "Iyi Geceler"; //Ternary If

            sonuc = time >= 6 && time < 11 ? "Gunaydin" : time <=18 ? "Iyi Gunler" : "Iyi Geceler!"; //Ic ice ternary if *istenildigi kadar cogaltilabilir ancak cok uzadiginda okuma guclugune sebep olur.

            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
