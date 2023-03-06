using Moq;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.Spells;
using ThundersEdge.Components.Spells.Fire;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Spells.Fire
{
    public class BurnShould
    {
        private readonly Spell spell;

        public BurnShould()
        {
            spell = new Burn();
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("[darkorange]Burn 🜂[/]", spell.Name.GenericName);
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