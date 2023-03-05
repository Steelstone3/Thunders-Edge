using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Spells;
using ThundersEdge.Components.Spells.Conventional;
using Xunit;

namespace ThundersEdgeTests.Components.Spells.Conventional
{
    public class SlashShould
    {
        private const byte TOTAL_CASTING_POINTS = 15;
        private const byte CASTING_COST = 1;
        private const byte DAMAGE = 15;
        private readonly Spell spell;

        public SlashShould()
        {
            spell = new Slash();
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("[lightslategrey]Slash ⚔[/]", spell.Name.GenericName);
        }

        [Fact]
        public void ContainsCastElement()
        {
            // Then
            Assert.Equal(CastingType.Conventional, spell.CastElement);
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