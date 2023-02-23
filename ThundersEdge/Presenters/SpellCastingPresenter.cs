using BubblesDivePlanner.Presenters;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Presenters
{
    public class SpellCastingPresenter : ISpellCastingPresenter
    {
        private readonly IPresenter presenter;

        public SpellCastingPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public ICard SelectAttackingCard(string playerName, IDeck deck)
        {
            presenter.Print($"{playerName}'s Turn");
            return presenter.GetCardFromDeck("Select Casting Card:", deck);
        }

        public ICard SelectDefendingCard(string playerName, IDeck deck)
        {
            presenter.Print($"{playerName}'s Turn");
            return presenter.GetCardFromDeck("Select Target Card:", deck);
        }

        public ISpell SelectSpell(ICard card) => presenter.GetSpellFromCard(card);
    }
}