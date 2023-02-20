using System.Collections.Generic;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
{
    public class Deck : IDeck
    {
        public Deck(IEnumerable<ICard> cards)
        {
            Cards = cards;
        }

        public IEnumerable<ICard> Cards { get; }
    }
}