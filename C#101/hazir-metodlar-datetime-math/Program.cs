using System;

namespace hazir_metodlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear); // içinde bulunulan yılın kaçıncı günü
            Console.WriteLine(DateTime.Now.ToLongDateString()); // 22 Mayıs 2023 Cuma
            Console.WriteLine(DateTime.Now.ToShortDateString()); //12.05.2023
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 23:11:05
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //23:11

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // (o anki günü rakamsal olarak olarak)
            Console.WriteLine(DateTime.Now.ToString("ddd")); // (o anki günün adını kısaltma olarak)
            Console.WriteLine(DateTime.Now.ToString("dddd")); // (o anki günün adını tam olarak)
            
            Console.WriteLine(DateTime.Now.ToString("MM")); // (o anki ayı rakamsal olarak)
            Console.WriteLine(DateTime.Now.ToString("MMM")); // (o anki ayı kısaltma olarak)
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // (o anki ayı tam olarak)
            
            Console.WriteLine(DateTime.Now.ToString("yy")); // (o anki yılı 2 haneli tam olarak)
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // (o anki yılı tam olarak)
            
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // Mutlak değer alır (- li bir değer olsa bile pozitif olarak döndürür.) => 25
            Console.WriteLine(Math.Sin(10)); // Sinus alma işlemi. => 10 un sinus karşılığını verir.
            Console.WriteLine(Math.Cos(10)); // Cosinus alma işlemi. => 10 un cosinus karşılığını verir.
            Console.WriteLine(Math.Tan(10)); // Tanjant alma işlemi. => 10 un tanjant karşılığını verir.
            
            Console.WriteLine(Math.Ceiling(22.3));//double veri tipi ile çalışır. 22.3 den büyük en küçük tamsayıyı döner. Yani => 23 Yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3)); //22.3 ü 22 olarak 22.7 yi 23 olarak yuvarlar. 22.5 olursa da 23 e yuvarlıyor. => 22
            Console.WriteLine(Math.Round(22.7)); //22.3 ü 22 olarak 22.7 yi 23 olarak yuvarlar. 22.5 olursa da 23 e yuvarlıyor. => 23
            Console.WriteLine(Math.Floor(22.7)); //22.7 den küçük en büyük tam sayıyı getirir. => 22 Yani Aşağı yuvarlar.

            Console.WriteLine(Math.Max(2,6)); // => 6
            Console.WriteLine(Math.Min(2,6)); // => 2
            
            Console.WriteLine(Math.Pow(3,4)); // 3 üzeri 4 => 81
            Console.WriteLine(Math.Sqrt(9)); // Karekök => 3
            Console.WriteLine(Math.Log(9)); // Logaritma 9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı

            




            Console.ReadLine();
        }
    }
}
