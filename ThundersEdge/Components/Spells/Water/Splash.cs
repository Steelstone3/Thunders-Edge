using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Water
{
    public class Splash : ISpell
    {
        public IName Name => new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Splash 🜄"));
        public CastingType CastElement => CastingType.Water;
        public byte CastingCost => 1;
        public byte Damage => 10;

        public void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, IAllCastPointTokens castPointTokens, ICard defendingCard)
        {
            damagingSpellCastSystem.CastSpell(this, castPointTokens, defendingCard);
        }
    }
}