using Spectre.Console;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Presenters
{
    public class Presenter : IPresenter
    {
        public Presenter()
        {
            CharacterPresenter = new CharacterPresenter(this);
            DeckPresenter = new DeckPresenter(this);
            SpellCastingPresenter = new SpellCastingPresenter(this);
        }

        public ICharacterPresenter CharacterPresenter { get; }
        public IDeckPresenter DeckPresenter { get; }
        public ISpellCastingPresenter SpellCastingPresenter { get; }

        public void Print(string message)
        {
            AnsiConsole.MarkupLine(message);
        }

        public string GetString(string message)
        {
            return AnsiConsole.Ask<string>(message);
        }

        public ICard GetCardFromDeck(string message, IDeck deck)
        {
            SelectionPrompt<ICard> selectionPrompt = new()
            {
                Converter = card => $"{card.Name.FirstName} {card.Name.Surname}"
            };

            ICard selection = AnsiConsole.Prompt(selectionPrompt
            .Title(message)
            .AddChoices(deck.Cards));

            Print($"Card selected: {selection.Name.FirstName} {selection.Name.Surname}");

            return selection;
        }

        public ISpell GetSpellFromCard(ICard card)
        {
            SelectionPrompt<ISpell> selectionPrompt = new()
            {
                Converter = spell => spell.Name.GenericName
            };

            ISpell selection = AnsiConsole.Prompt(selectionPrompt
            .Title("Select Spell:")
            .AddChoices(card.SpellGroup.Spells));

            Print($"Spell selected: {selection.Name.GenericName}");

            return selection;
        }
    }
}
