using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Spells;
using ThundersEdge.Systems.Spells;

namespace ThundersEdgeTests.Components.Spells.Water
{
    public class TidalWave : Spell
    {
        public TidalWave()
        {
            CastElement = CastingType.Water;
            Name = new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Tidal Wave 🜄"));
            CastingCost = 3;
            RemainingCastingPoints = 6;
            Damage = 35;
        }
    }
}