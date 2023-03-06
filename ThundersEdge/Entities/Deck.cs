using System.Collections.Generic;
using System.Linq;
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

        public bool IsDeckStillInPlay()
        {
            // TODO Add message here about loosing the game if false
            return Cards.Any(c => c.IsCardStillInPlay());
        }
    }
}