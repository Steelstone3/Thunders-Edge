using Spectre.Console;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace BubblesDivePlanner.Presenters
{
    public class Presenter : IPresenter
    {
        public void Print(string message)
        {
            AnsiConsole.WriteLine(message);
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

            return AnsiConsole.Prompt(selectionPrompt
            .Title(message)
            .AddChoices(deck.Cards));
        }

        public ISpell GetSpellFromCard(ICard card)
        {
            SelectionPrompt<ISpell> selectionPrompt = new()
            {
                Converter = spell => spell.Name.GenericName
            };

            return AnsiConsole.Prompt(selectionPrompt
            .Title("Select Spell:")
            .AddChoices(card.SpellGroup.Spells));
        }
    }
}
