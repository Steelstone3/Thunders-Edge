using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Components.Spells.Fire
{
    public class FireBolt : ISpell
    {
        public IName Name => new Name("Fire Bolt 🜂");
        public CastingType CastElement => CastingType.Fire;
        public byte Damage => 25;
        public byte CastingCost => 2;

        public void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, IAllCastPointTokens castPointTokens, ICard defendingCard)
        {
            damagingSpellCastSystem.CastSpell(this, castPointTokens, defendingCard);
        }
    }
}