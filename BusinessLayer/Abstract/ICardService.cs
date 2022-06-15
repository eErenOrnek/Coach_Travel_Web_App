using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICardService
    {
        void InitializeCard(string userId);
        Card GetCardByUserId(string userId);
        void AddToCard(string userId, int destinationId, int quantity);
        void DeleteFromCard(string userId, int destinationId);
        void ClearCard(int cardId);
    }
}
