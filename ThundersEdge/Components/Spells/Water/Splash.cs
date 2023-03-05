using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Water
{
    public class Splash : Spell
    {
        public Splash()
        {
            CastElement = CastingType.Water;
            Name = new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Splash 🜄"));
            CastingCost = 1;
            Damage = 10;
            RemainingCastingPoints = 15;
        }
    }
}