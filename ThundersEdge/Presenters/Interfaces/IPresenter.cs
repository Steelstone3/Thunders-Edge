using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace BubblesDivePlanner.Presenters
{
    public interface IPresenter
    {
        void Print(string message);
        string GetString(string message);
        ICard GetCardFromDeck(string message, IDeck deck);
        ISpell GetSpellFromCard(ICard card);
    }
}