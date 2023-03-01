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

        public void PrintPlayerTurn(IName playerName)
        {
            presenter.Print($"\n\n\n{playerName.GenericName}'s Turn\n");
        }

        public ICard SelectAttackingCard(IDeck deck)
        {
            return presenter.GetCardFromDeck("Select Casting Card:", "Casting Card Selected:", deck);
        }

        public ICard SelectDefendingCard(IDeck deck)
        {
            return presenter.GetCardFromDeck("Select Target Card:", "Target Card Selected:", deck);
        }

        public ISpell SelectSpell(ICard card) => presenter.GetSpellFromCard(card);
    }
}