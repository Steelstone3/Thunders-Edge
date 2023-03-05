using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Conventional
{
    public class Slash : Spell
    {
        public Slash()
        {
            CastElement = CastingType.Conventional;
            Name = new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Slash ⚔"));
            Damage = 15;
            CastingCost = 1;
            RemainingCastingPoints = 15;
        }
    }
}