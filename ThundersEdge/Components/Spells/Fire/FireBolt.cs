using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Fire
{
    public class FireBolt : ISpell
    {
        private readonly IName name = new Name("Fire Bolt 🜂");
        public IName Name => new Name($"{GetColouredSpellName}");
        public CastingType CastElement => CastingType.Fire;
        public byte Damage => 25;
        public byte CastingCost => 2;

        public void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, IAllCastPointTokens castPointTokens, ICard defendingCard)
        {
            damagingSpellCastSystem.CastSpell(this, castPointTokens, defendingCard);
        }

        private string GetColouredSpellName => new ApplySpellColourSystem().ApplySpellColour(CastElement, name);
    }
}