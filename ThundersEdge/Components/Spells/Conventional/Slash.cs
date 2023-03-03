using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Conventional
{
    public class Slash : ISpell
    {
        public IName Name => new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Slash ⚔"));
        public CastingType CastElement => CastingType.Conventional;
        public byte Damage => 15;
        public byte CastingCost => 1;

        public void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, IAllCastPointTokens castPointTokens, ICard defendingCard)
        {
            damagingSpellCastSystem.CastSpell(this, castPointTokens, defendingCard);
        }
    }
}