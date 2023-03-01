using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Entities
{
    public class Card : ICard
    {
        private readonly IDeckPresenter deckPresenter;

        public Card(IDeckPresenter deckPresenter, ICharacterName name, IHealth health, ISpellGroup spellGroup)
        {
            this.deckPresenter = deckPresenter;
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
            deckPresenter.PrintCardTakingDamage(damage, Name, Health);
        }
    }
}