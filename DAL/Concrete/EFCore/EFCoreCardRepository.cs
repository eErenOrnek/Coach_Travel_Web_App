using DAL.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreCardRepository : EFCoreGenericRepository<Card, Context>, ICardRepository
    {
        public void ClearCard(int cardId)
        {
            using var context = new Context();
            var query = @"DELETE FROM CardTicket WHERE CardId = @p0";
            context.Database.ExecuteSqlRaw(query, cardId);
        }

        public void DeleteTicketFromCard(int cardId, int destinationId)
        {
            using var context = new Context();
            var query = @"DELETE FROM CardTicket WHERE CardId = @p0 AND DestinationId = @p1";
            context.Database.ExecuteSqlRaw(query, cardId, destinationId);
        }

        public Card GetCardByUserId(string userId)
        {
            using var context = new Context();
            return context
                .Cards
                .Include(i => i.CardTickets)
                .ThenInclude(i => i.Destination)
                .FirstOrDefault(i => i.UserId == userId);
        }

        public override void Update(Card entity)
        {
            using (var context = new Context())
            {
                context.Cards.Update(entity);
                context.SaveChanges();
            }
            base.Update(entity);
        }
    }
}
