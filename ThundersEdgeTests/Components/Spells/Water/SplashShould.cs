using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Spells;
using ThundersEdge.Components.Spells.Water;
using Xunit;

namespace ThundersEdgeTests.Components.Spells.Water
{
    public class SplashShould
    {
        private readonly Spell spell;

        public SplashShould()
        {
            spell = new Splash();
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("[skyblue1]Splash 🜄[/]", spell.Name.GenericName);
        }

        [Fact]
        public void ContainsCastElement()
        {
            // Then
            Assert.Equal(CastingType.Water, spell.CastElement);
        }

        [Fact]
        public void ContainsCastPower()
        {
            // Then
            Assert.Equal(1, spell.CastingCost);
        }

        [Fact]
        public void ContainsTotalCastingPoints()
        {
            // Then
            Assert.Equal(15, spell.RemainingCastingPoints);
        }

        [Fact]
        public void ContainsDamage()
        {
            // Then
            Assert.Equal(10, spell.Damage);
        }
    }
}