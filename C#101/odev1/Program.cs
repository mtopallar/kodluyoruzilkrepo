using System;
using System.Linq;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CiftSayilariYazdir();
            //EsitVeyaTamBolen();
            //ReverseWords();
            WordAndLetterCounter();



            Console.ReadLine();
        }

        static void CiftSayilariYazdir()
        {
            Console.Write("Lütfen dizi boyutunu pozitif tamsayi olarak giriniz: ");
            if (!HelperMethods.isIntDataValid(out int diziBoyutu))
                return;
            int[] sayiDizisi = new int[diziBoyutu];
            Console.WriteLine("Lütfen kontrol etmek istediğiniz pozitif sayilari giriniz: ");
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write($"{i + 1}. sayi: ");
                if (!HelperMethods.isIntDataValid(out int sayi))
                    return;
                sayiDizisi[i] = sayi;
            }
            Console.WriteLine("İlgili dizi içinde: ");
            foreach (var item in sayiDizisi)
            {
                if (item % 2 == 0)
                    Console.WriteLine($"{item} çift sayidir.");
            }

        }

        static void EsitVeyaTamBolen()
        {
            Console.Write("Lütfen işlemi kaç adet sayı ile yapmak istediğinizi pozitif tamsayı olarak giriniz: ");
            if (!HelperMethods.isIntDataValid(out int diziBoyutu))
                return;

            Console.Write("Lütfen kontrol etmek istediğiniz sayıyı pozitif tamsayı olarak giriniz: ");
            if (!HelperMethods.isIntDataValid(out int kontrolSayisi))
                return;

            int[] sayiDizisi = new int[diziBoyutu];
            Console.WriteLine("Lütfen dizi elemanlarını pozitif tamsayı olarak giriniz: ");
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write($"{i + 1}. sayı : ");
                if (!HelperMethods.isIntDataValid(out int sayi))
                    return;
                sayiDizisi[i] = sayi;
            }
            foreach (var item in sayiDizisi)
            {
                if (item == kontrolSayisi || item % kontrolSayisi == 0)
                    Console.WriteLine($"{item} {kontrolSayisi} ile tam bölünür yada eşittir.");
            }
        }

        static void ReverseWords()
        {
            Console.Write("Lütfen kaç kelimeden oluşacak bir dizi istediğinizi pozitif tamsayı olarak belirtin: ");
            if(!HelperMethods.isIntDataValid(out int diziBoyutu))
                return;
            string[] kelimeler = new string[diziBoyutu];
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.Write($"{i+1}. kelime : ");
                if(!HelperMethods.isStringDataValid(out string ifade))
                    return;
                kelimeler[i] = ifade;
            }
            Console.WriteLine("Sondan başa doğru yazdığınız kelimeler: ");
            
            for (int i = kelimeler.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i+1}. kelime : {kelimeler[i]}");
            }
        }

        static void WordAndLetterCounter()
        {
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            if(!HelperMethods.isStringDataValid(out string ifade))
                return;
            string[] kelimeler = ifade.Split(" ");
            Console.WriteLine("Girilen ifade: ");
            Console.WriteLine($"{kelimeler.Length} kelimeden,");
            char[] harfler = ifade.ToCharArray();
            Console.WriteLine($"Boşluklar -ve varsa noktalama işaretleri- dahil {harfler.Length} karakterden,");
            string bosluksuz = String.Join("",kelimeler);
            char[] bosluksuzHarfler = bosluksuz.ToCharArray();
            Console.WriteLine($"Boşluklar hariç -ve varsa noktalama işaretleri dahil- {bosluksuzHarfler.Length} karakterden oluşmaktadır.");
        }
    }

    static class HelperMethods
    {
        public static bool isIntDataValid(out int returnNumber)
        {
            returnNumber = 0;
            bool isItValid = int.TryParse(Console.ReadLine(), out int number);
            if (!isItValid)
            {
                Console.WriteLine("Hatalı bir veri girdiniz.");
                return false;
            }
            else if (number <= 0)
            {
                Console.WriteLine("Lütfen pozitif tamsayı ile tekrar deneyiniz.");
                return false;
            }
            returnNumber = number;
            return true;
        }

        public static bool isStringDataValid(out string returnString)
        {
            returnString = String.Empty;
            string ifade = Console.ReadLine();
            if(String.IsNullOrEmpty(ifade) || String.IsNullOrWhiteSpace(ifade))
            {
                Console.WriteLine("Boşluk ifadesi geçerli bir metin değildir.");
                return false;
            }
            returnString = ifade;
            return true;
        }
    }

}
