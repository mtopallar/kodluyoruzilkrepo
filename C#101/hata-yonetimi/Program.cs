using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Bir sayı giriniz:");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmis oldugunuz sayı : " + sayi);                
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Hata : " + ex.Message);                
            // }
            // finally
            // {
            //     // Eger varsa basarili casede de basarisiz casede de finally calisir. Ancak bulunmak zorunda degildir.
            //     Console.WriteLine("Islem tamamlandi.");
            // }

            //Hata tipi belli olan hatalari ozellestirmek.
            try
            {
                //int a = int.Parse(null);                
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                //Burasi bir if blogu gibi eger hata turu ArgumentNullException ise  devreye girer. Bunun altina farklı hata tikleri icin farkli catch ekleyebiliyoruz.
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Veri boyutu / kapasitesi uygun degil.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Islem Basariyle Tamamlandi.");
            }
            
            Console.ReadKey();
        }
    }
}
