using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components
{
    public class Card : ICard
    {
        public Card(ICharacterName name, IHealth health, ISpellGroup spellGroup)
        {
            Name = name;
            Health = health;
            SpellGroup = spellGroup;
        }

        public ICharacterName Name { get; }
        public IHealth Health { get; }
        public ISpellGroup SpellGroup { get; }
    }
}