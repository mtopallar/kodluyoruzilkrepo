using System;
using proje2.constants;
using proje2.Helpers;

namespace proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            CardManager cardManager = new CardManager(new EmployeeManager());
            // 3 bölümlü board her birinde ilgili kartlar listelenecek.
            Console.WriteLine("\nLüften yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("*****************************************\n");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            if(int.TryParse(Console.ReadLine(), out int selection) && selection == 1 || selection == 2 || selection == 3 || selection == 4)
            {
                switch (selection)
                {
                    case 1:
                        cardManager.ListCardBoard();
                        break;
                    case 2:
                        Card card = new()
                        {
                            EmployeeId = GetCardComponentsFromUser.GetUsersIdFromUser(new EmployeeManager()),
                            Title = GetCardComponentsFromUser.TakeCardTitleFromUser(),
                            Content = GetCardComponentsFromUser.TakeCardContentFromUser(),
                            Status = GetCardComponentsFromUser.GetCardStatusFromUser(),
                            Size = GetCardComponentsFromUser.TakeCardSizeFromUser()
                        };
                        cardManager.AddCard(card);
                        break;
                    case 3:
                        cardManager.DeleteCard(GetCardComponentsFromUser.TakeCardTitleFromUser());
                        break;
                    case 4:
                        cardManager.ChangeCardStatus(GetCardComponentsFromUser.TakeCardTitleFromUser());
                        break;
                }
            }
            else
            {
                Console.WriteLine("Hatalı bir seçim yaptınız.Lütfen tekrar deneyiniz.");
                Main(args);
            }


            Console.ReadLine();
        }
    }
}
