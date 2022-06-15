using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface ICardRepository : IRepository<Card>
    {
        Card GetCardByUserId(string userId);
        void DeleteTicketFromCard(int cardId, int destinationId);
        void ClearCard(int cardId);
    }
}
