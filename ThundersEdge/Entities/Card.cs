using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
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