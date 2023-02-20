using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface ISpellCastingPresenter
    {
        ICard SelectAttackingCard(IDeck deck);
        ICard SelectDefendingCard(IDeck deck);
        ISpell SelectSpell(ICard card);
    }
}