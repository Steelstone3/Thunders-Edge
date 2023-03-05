using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Spells;
using ThundersEdge.Components.Spells.Fire;
using Xunit;

namespace ThundersEdgeTests.Components.Spells.Fire
{
    public class FireBoltShould
    {
        private readonly Spell spell;

        public FireBoltShould()
        {
            spell = new FireBolt();
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("[darkorange]Fire Bolt 🜂[/]", spell.Name.GenericName);
        }

        [Fact]
        public void ContainsCastElement()
        {
            // Then
            Assert.Equal(CastingType.Fire, spell.CastElement);
        }

        [Fact]
        public void ContainsCastingCost()
        {
            // Then
            Assert.Equal(2, spell.CastingCost);
        }

        [Fact]
        public void ContainsTotalCastingPoints()
        {
            // Then
            Assert.Equal(10, spell.RemainingCastingPoints);
        }

        [Fact]
        public void ContainsDamage()
        {
            // Then
            Assert.Equal(25, spell.Damage);
        }
    }
}