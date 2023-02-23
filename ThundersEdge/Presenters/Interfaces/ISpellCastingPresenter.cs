using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface ISpellCastingPresenter
    {
        ICard SelectAttackingCard(string playerName, IDeck deck);
        ICard SelectDefendingCard(string playerName, IDeck deck);
        ISpell SelectSpell(ICard card);
    }
}