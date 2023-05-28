using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using proje2.constants;

namespace proje2.Helpers
{
    public class GetCardComponentsFromUser
    {
        // kart başlığını kullanıcıdan al
        public static string TakeCardTitleFromUser(string message = null)
        {
            if (message is not null)
                Console.WriteLine(message);
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            return Console.ReadLine();
        }

        // kart içeriğini kullanıcıdan al
        public static string TakeCardContentFromUser()
        {
            Console.WriteLine("Lütfen kart içeriğini yazınız: ");
            return Console.ReadLine();
        }

        // XS(1),S(2),M(3),L(4),XL(5) kart büyüklüğünü kullanıcıdan al
        public static string TakeCardSizeFromUser()
        {
            Console.WriteLine("Lütfen büyüklük seçiniz => XS(1), S(2), M(3), L(4), XL(5)");
            if (int.TryParse(Console.ReadLine(), out int selection) && selection == 1 || selection == 2 || selection == 3 || selection == 4 || selection == 5)
            {
                switch (selection)
                {
                    case 1:
                        return Sizes.XS.ToString();
                    case 2:
                        return Sizes.S.ToString();
                    case 3:
                        return Sizes.M.ToString();
                    case 4:
                        return Sizes.L.ToString();
                    case 5:
                        return Sizes.XL.ToString();
                }
            }
            Console.WriteLine("Hatalı seçim yaptınız.Tekrar deneyin.");
            return TakeCardSizeFromUser();
        }

        // takım üyesinin id sini kullanıcıdan al
        public static int GetUsersIdFromUser(IEmployeeService employeeService)
        {
            Console.WriteLine("Lütfen takım üyesi seçiniz: ");
            if (int.TryParse(Console.ReadLine(), out int userId))
            {
                var tryGetUser = employeeService.GetById(userId);
                if (tryGetUser is not null)
                    return tryGetUser.Id;
            }
            Console.WriteLine("Takım üyesi kayıtlı değil. Lütfen tekrar deneyiniz:");
            return GetUsersIdFromUser(employeeService);
        }

        public static string GetCardStatusFromUser(string message = null)
        {
            if (message is not null)
                Console.WriteLine(message);
            else
                Console.WriteLine("Lütfen kartın durum statüsünü seçiniz: ");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
            if(int.TryParse(Console.ReadLine(), out int selection) && selection == 1 || selection == 2 || selection == 3)
            {
                switch (selection)
                {
                    case 1:
                        return Statuses.Todo;
                    case 2:
                        return Statuses.InProgress;
                    case 3:
                        return Statuses.Done;
                }
            }
            Console.WriteLine("Hatalı bir işlem yaptınız. Lütfen tekrar deneyin.");
            return GetCardStatusFromUser();
        }

    }
}