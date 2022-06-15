using BusinessLayer.Abstract;
using DAL.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CardManager : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public void AddToCard(string userId, int destinationId, int quantity)
        {
            var card = GetCardByUserId(userId);
            if (card!= null)
            {
                var index = card.CardTickets.FindIndex(i => i.DestinationId == destinationId);
                if (index < 0)
                {
                    card.CardTickets.Add(new CardTicket()
                    {
                        DestinationId = destinationId,
                        Quantity = quantity,
                        CardId = card.Id
                    });
                }
                else
                {
                    card.CardTickets[index].Quantity += quantity;
                }
                _cardRepository.Update(card);
            }
        }

        public void ClearCard(int cardId)
        {
            _cardRepository.ClearCard(cardId);
        }

        public void DeleteFromCard(string userId, int destinationId)
        {
            var card = GetCardByUserId(userId);
            if (card!=null)
            {
                _cardRepository.DeleteTicketFromCard(card.Id, destinationId);
            }
        }

        public Card GetCardByUserId(string userId)
        {
            return _cardRepository.GetCardByUserId(userId);
        }

        public void InitializeCard(string userId)
        {
            var card = new Card() { UserId = userId };
            _cardRepository.Create(card);
        }
    }
}
