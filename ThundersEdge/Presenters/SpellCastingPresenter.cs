using BubblesDivePlanner.Presenters;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Presenters
{
    internal class SpellCastingPresenter : ISpellCastingPresenter
    {
        private readonly IPresenter presenter;

        public SpellCastingPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public ICard SelectAttackingCard(IDeck deck)
        {
            throw new System.NotImplementedException();
        }

        public ICard SelectDefendingCard(IDeck deck)
        {
            throw new System.NotImplementedException();
        }

        public ISpell SelectSpell(ICard card)
        {
            throw new System.NotImplementedException();
        }
    }
}