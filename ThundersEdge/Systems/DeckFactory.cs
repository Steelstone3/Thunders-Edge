using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge
{
    public class DeckFactory : IDeckFactory
    {
        private const int DECK_SIZE = 5;
        private readonly ICardFactory cardFactory;

        public DeckFactory(ICardFactory cardFactory)
        {
            this.cardFactory = cardFactory;
        }

        public IDeck Create() => new Deck(AddCards());

        private IEnumerable<ICard> AddCards()
        {
            List<ICard> cards = new();

            for (int i = 0; i < DECK_SIZE; i++)
            {
                cards.Add(cardFactory.Create());
            }

            return cards;
        }
    }
}