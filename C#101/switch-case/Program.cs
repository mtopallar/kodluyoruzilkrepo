using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                //month bir int dolayisi ile case de sadece int degerler sorgulayabiliriz.
                case 1:
                    Console.WriteLine("Ocak Ayindasiniz!");
                    break;
                case 2:
                    Console.WriteLine("Subat Ayindasiniz!");
                    break;
                case 4:  // => illa sirali yazmak zorunda degiliz. Case ler siradan devam eder.
                     Console.WriteLine("Nisan Ayindasiniz!");
                     break;
                case 3:
                    Console.WriteLine("Mart Ayindasiniz!");
                    break;
                case 5:
                    Console.WriteLine("Mayis Ayindasiniz!");
                    break;
                case 6:
                    Console.WriteLine("Haziran Ayindasiniz!");
                    break;
                case 7:
                    Console.WriteLine("Temmuz Ayindasiniz!");
                    break;
                case 8:
                    Console.WriteLine("Agustos Ayindasiniz!");
                    break;
                case 9:
                    Console.WriteLine("Eylul Ayindasiniz!");
                    break;
                case 10:
                    Console.WriteLine("Ekim Ayindasiniz!");
                    break;
                case 11:
                    Console.WriteLine("Kasim Ayindasiniz!");
                    break;
                case 12:
                    Console.WriteLine("Aralik Ayindasiniz!");
                    break;
                default:
                    Console.WriteLine("Hatali veri girisi.");
                    //default hicbir case e uyulmadiginda yapilacak olan islem.
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Mevsimindesiniz.");
                    break;

                    default:
                //Default switch - case yapilarinda zorunlu degil ancak bulunmasi faydalidir. default en sonda olmak zorunda degil. Mesela bu default burada dururken de yine cikti olarak ilkbahar mevsimindesiniz yazisini veriyor. Once caseler mutlaka denenir, eger hicbir case e uymayan bir durum olursa default calisir.
                    Console.WriteLine("Hatali veri girisi.");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar Mevsimindesiniz.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz..");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz.");
                    break;                
                // default:
                // //Default switch - case yapilarinda zorunlu degil ancak bulunmasi faydalidir. default en sonda olmak zorunda degil. Yukaridaki case lerden birinin break komutunun hemen ardina da tasinabilir.
                //     Console.WriteLine("Hatali veri girisi.");
                //     break;
            }
        }
    }
}
