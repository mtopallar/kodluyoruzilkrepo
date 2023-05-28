using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje2
{
    public interface ICardService
    {
        void ListCardBoard();
        void AddCard(Card card);
        void DeleteCard(string cardTitle); //isterlerde title ile yapılması isteniyor.
        void ChangeCardStatus(string cardTitle); //isterlerde title ile yapılması isteniyor.
    }
}