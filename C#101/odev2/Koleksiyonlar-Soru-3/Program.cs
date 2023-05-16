using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin girip Enter tuşuna basınız:");
            string cumle = Console.ReadLine().Trim().ToLower();
            List<string> metindekiSesliler = new List<string>();

            if (cumle.Length == 0)
            {
                Console.WriteLine("Lütfen geçerli bir cümle yazın");
                return;
            }
            foreach (var harf in cumle)
            {
                switch (harf)
                {
                    case 'a':
                        metindekiSesliler.Add("a");
                        break;
                    case 'e':
                        metindekiSesliler.Add("e");
                        break;
                    case 'ı':
                        metindekiSesliler.Add("ı");
                        break;
                    case 'i':
                        metindekiSesliler.Add("i");
                        break;
                    case 'o':
                        metindekiSesliler.Add("o");
                        break;
                    case 'ö':
                        metindekiSesliler.Add("ö");
                        break;
                    case 'u':
                        metindekiSesliler.Add("u");
                        break;
                    case 'ü':
                        metindekiSesliler.Add("ü");
                        break;
                }
            }
            metindekiSesliler.Sort();
            Console.WriteLine("Girilen cümle içindeki sesli harfler: ");
            foreach (var item in metindekiSesliler)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
