using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Models
{
    public class CardModel
    {
        public int CardId { get; set; }
        public List<CardTicketModel> CardTickets { get; set; }
        public double TotalPrice()
        {
            return CardTickets.Sum(i => i.Price * i.Quantity);
        }
    }
}
