using System.Linq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Entities
{
    public class Card : ICard
    {
        private readonly IPresenter presenter;

        public Card(IPresenter presenter, ICharacterName name, IHealth health, ISpellGroup spellGroup)
        {
            this.presenter = presenter;
            Name = name;
            Health = health;
            SpellGroup = spellGroup;
        }

        public ICharacterName Name { get; }
        public IHealth Health { get; }
        public ISpellGroup SpellGroup { get; }

        public void TakeDamage(byte damage)
        {
            Health.TakeDamage(damage);
            presenter.DeckPresenter.PrintCardTakingDamage(damage, Name, Health);
        }

        public string GetSummary()
        {
            string summary = $"{Name.FirstName} {Name.Surname} | [red]{Health.CurrentHealth}[/]/[red]{Health.MaximumHealth}[/] | | ";

            summary += string.Join("   ", SpellGroup.Spells.Select(s => s.Name.GenericName));
            summary = summary.TrimEnd();
            summary += " | |";

            return summary;
        }
    }
}