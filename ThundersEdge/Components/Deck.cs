using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components
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