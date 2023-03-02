using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.SpellGroups.Water;
using Xunit;

namespace ThundersEdgeTests.Components.SpellGroups.Water
{
    public class WaterOffensiveSpellGroupShould
    {
        private readonly ISpellGroup waterOffensiveSpellGroup = new WaterOffensiveSpellGroup();

        [Fact]
        public void ContainsSpells()
        {
            // Then
            Assert.NotEmpty(waterOffensiveSpellGroup.Spells);
        }
    }
}