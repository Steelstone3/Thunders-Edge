using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Spells.Fire
{
    public class Burn : Spell
    {
        public Burn()
        {
            CastElement = CastingType.Fire;
            Name = new ApplySpellColourSystem().ApplySpellColour(CastElement, new Name("Burn 🜂"));
            CastingCost = 1;
            RemainingCastingPoints = 15;
            Damage = 10;
        }
    }
}