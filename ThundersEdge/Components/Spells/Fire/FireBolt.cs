using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Fire
{
    public class FireBolt : Spell
    {
        public FireBolt()
        {
            CastElement = CastingType.Fire;
            Name = new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Fire Bolt 🜂"));
            CastingCost = 2;
            RemainingCastingPoints = 10;
            Damage = 25;
        }
    }
}