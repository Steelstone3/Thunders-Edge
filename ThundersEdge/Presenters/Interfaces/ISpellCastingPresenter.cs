using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface ISpellCastingPresenter
    {
        void PrintPlayerTurn(IName playerName);
        ICard SelectAttackingCard(IDeck deck);
        ICard SelectDefendingCard(IDeck deck);
        ISpell SelectSpell(ICard card);
    }
}