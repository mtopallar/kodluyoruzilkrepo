using System;

namespace debugging_watch_variables
{  
    class Program
    {
        //Breakpoint kullanarak kod akisi ilgili satira geldiginde kodun kirilmasini ve detayli inceleme imkani vermesini saglayabiliriz.
        //Benzer sekilde bir degiskeni veya blogu sag click ile add to watc komutunu kullanarak watch penceresine ekleyebiliriz. burada ilgili degisken icin cesitli senaryolara gore cesitli sartlari test edebiliriz. Kod akip degiskenin tanimli oldugu bloktan çikarsa watch dan artik ilgili degiskene erisilemedigine dair bir mesaj airiz.
        //Continue (F5) => Bir sonraki breakpoint e kadar kodu akitir.
        //Step over (F10) => adim adim ilerler.
        //Stem Into (F11) => adim adim ilerlerken icine girebilecegi komplex bir nesneye gelirse o nesnenin icindeki işlemleri gormemizi saglamak icin ilgili objenin icindeki islemleri de gosterir. Oradaki islemler bittiginde kodumuza geri doneriz.

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayı : " + sayi);                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message);                
            }
            finally
            {
                Console.WriteLine("Islem tamamlandi.");
            }

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
