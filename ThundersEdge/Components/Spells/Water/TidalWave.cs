using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;

namespace ThundersEdgeTests.Components.Spells.Water
{
    public class TidalWave : ISpell
    {
        private readonly IName name = new Name("Tidal Wave 🜄");
        public IName Name => GetColouredSpellName;
        public CastingType CastElement => CastingType.Water;
        public byte CastingCost => 3;
        public byte Damage => 35;
        private IName GetColouredSpellName => new ApplySpellColourSystem().ApplySpellColour(CastElement, name);

        public void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, IAllCastPointTokens castPointTokens, ICard defendingCard)
        {
            damagingSpellCastSystem.CastSpell(this, castPointTokens, defendingCard);
        }
    }
}