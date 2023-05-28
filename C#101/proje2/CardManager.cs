using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proje2.constants;
using proje2.Helpers;

namespace proje2
{
    public class CardManager : ICardService
    {
        List<Card> CardList;
        IEmployeeService _employeeService;

        public CardManager(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            if(CardList is null)
                CardList = GetPredefinedList();
        }

        public void ListCardBoard()
        {
            var getTodos = GetToDoList();
            if(getTodos.Count != 0)
                WriteListToConsole(getTodos);
            else
                Console.WriteLine("\n~ BOŞ ~");

            var getInProgreses = GetInProgressList();
            if(getInProgreses.Count != 0)
                WriteListToConsole(getInProgreses);
            else
                Console.WriteLine("\n~ BOŞ ~");

            var getDones = GetDoneList();
            if(getDones.Count != 0)
                WriteListToConsole(getDones);
            else
                Console.WriteLine("\n~ BOŞ ~");
        }
        public void AddCard(Card card)
        {
            card.Id = CreateCardId();
            CardList.Add(card);
            Console.WriteLine("Kart ekleme başarılı");
            ListCardBoard();
        }

        public void ChangeCardStatus(string cardTitle)
        {
            var currentCard = CardList.FirstOrDefault(x => x.Title == cardTitle);
            if (currentCard is not null)
            {
                // BURADA BİR DÜZENELEME YAPILABİLİR AŞAĞIDAKİ METOD KULLANILARAK
                var getEmployee = _employeeService.GetById(currentCard.EmployeeId);
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine($"Başlık: {currentCard.Title}, İçerik: {currentCard.Content}, Atanan kişi: {getEmployee.Name} {getEmployee.Lastname}, Büyüklük: {currentCard.Size}, Line: {currentCard.Status}");
                currentCard.Status = GetCardComponentsFromUser.GetCardStatusFromUser("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("Güncelleme Başarılı.");
                ListCardBoard();
            }
            else
            {
                if (IfCardNotFound(out int selection))
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("İşlem sonlandırıldı.");
                            break;
                        case 2:
                            Console.WriteLine("Öncelikle kart başlığı ile kartı seçmeniz gerekiyor.");
                            ChangeCardStatus(GetCardComponentsFromUser.TakeCardTitleFromUser());
                            break;
                    }
                }
            }
        }

        public void DeleteCard(string cardTitle)
        {
            var findedCards = CardList.FindAll(x => x.Title == cardTitle);
            if (findedCards.Count != 0)
            {
                findedCards.ForEach(x => CardList.Remove(x));
                Console.WriteLine("Sİlme işlemi başarılı.");
                ListCardBoard();
            }
            else
            {
                if (IfCardNotFound(out int selection))
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("İşlem sonlandırıldı.");
                            break;
                        case 2:
                            DeleteCard(GetCardComponentsFromUser.TakeCardTitleFromUser());
                            break;
                    }
                }
            }
        }

        private List<Card> GetDoneList()
        {
            Console.WriteLine("DONE Line");
            Console.WriteLine("*************************");
            return CardList.FindAll(x => x.Status == Statuses.Done);
        }

        private List<Card> GetInProgressList()
        {
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*************************");
            return CardList.FindAll(x => x.Status == Statuses.InProgress);
        }

        private List<Card> GetToDoList()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("*************************");
            return CardList.FindAll(x => x.Status == Statuses.Todo);
        }

        private bool IfCardNotFound(out int selection)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");

            if (int.TryParse(Console.ReadLine(), out selection) && selection == 1 || selection == 2)
                return true;
            Console.WriteLine("Hatalı bir seçim yaptınız.");
            return false;
        }

        private void WriteListToConsole(List<Card> cardListToWrite)
        {
            foreach (var item in cardListToWrite)
            {
                var getUser = _employeeService.GetById(item.Id);
                Console.WriteLine($"Başlık          :{item.Title}");
                Console.WriteLine($"İçerik          :{item.Content}");
                Console.WriteLine($"Atanan Kişi     :{getUser.Name} {getUser.Lastname}");
                Console.WriteLine($"Büyüklük        :{item.Size}\n");
            }
        }
        private List<Card> GetPredefinedList()
        {
            CardList = new()
            {
                new Card{Id=1,EmployeeId=1,Title="Alınacaklar",Content="Ofis için tüketim ürünleri tedarik edilecek.",Status=Statuses.Todo,Size=Sizes.XS.ToString()},
                new Card{Id=2,EmployeeId = 3, Title = "Eksiklerin Saptanması", Content = "Stoğu kritik düzeyde azalan envanterin saptanması", Status=Statuses.InProgress,Size=Sizes.M.ToString()},
                new Card{Id = 3, EmployeeId = 4, Title = "Envanter Sayımı", Content = "Yıl sonu envanter sayımının organizasyonu",Status = Statuses.InProgress,Size = Sizes.L.ToString()}
            };
            return CardList;
        }
        private int CreateCardId()
        {
           return CardList.OrderByDescending(x => x.Id).ToList()[0].Id + 1;
        }
    }
}