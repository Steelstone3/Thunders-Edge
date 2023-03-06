using System.Collections.Generic;
using System.Linq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Entities
{
    public class Deck : IDeck
    {
        public Deck(IEnumerable<ICard> cards)
        {
            Cards = cards;
        }

        public IEnumerable<ICard> Cards { get; }

        public bool IsDeckStillInPlay(IPresenter presenter, IName name)
        {
            bool isDeckStillInPlay = Cards.Any(c => c.IsCardStillInPlay());

            if(!isDeckStillInPlay)
            {
                presenter.DeckPresenter.PrintDeckDefeated(name);
            }

            return isDeckStillInPlay;
        }
    }
}