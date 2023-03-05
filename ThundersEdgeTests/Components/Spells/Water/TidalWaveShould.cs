using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Spells;
using Xunit;

namespace ThundersEdgeTests.Components.Spells.Water
{
    public class TidalWaveShould
    {
        private const byte TOTAL_CASTING_POINTS = 6;
        private const byte CASTING_COST = 3;
        private const byte DAMAGE = 35;
        private readonly Spell spell;

        public TidalWaveShould()
        {
            spell = new TidalWave();
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("[skyblue1]Tidal Wave 🜄[/]", spell.Name.GenericName);
        }

        [Fact]
        public void ContainsCastElement()
        {
            // Then
            Assert.Equal(CastingType.Water, spell.CastElement);
        }

        [Fact]
        public void ContainsCastingCost()
        {
            // Then
            Assert.Equal(CASTING_COST, spell.CastingCost);
        }

        [Fact]
        public void ContainsTotalCastingPoints()
        {
            // Then
            Assert.Equal(TOTAL_CASTING_POINTS, spell.RemainingCastingPoints);
        }

        [Fact]
        public void ContainsDamage()
        {
            // Then
            Assert.Equal(DAMAGE, spell.Damage);
        }
    }
}