using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface IPresenter
    {
        IDeckPresenter DeckPresenter { get; }
        ISpellCastingPresenter SpellCastingPresenter { get; }
        ICharacterPresenter CharacterPresenter { get; }
        void Print(string message);
        string GetString(string message);
        ICard GetCardFromDeck(string selectionMessage, string selectedMessage, IDeck deck);
        ISpell GetSpellFromCard(ICard card);
    }
}