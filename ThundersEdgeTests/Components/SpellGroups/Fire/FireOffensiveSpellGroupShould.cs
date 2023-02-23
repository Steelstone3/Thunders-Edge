using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.SpellGroups.Fire
{
    public class FireOffensiveSpellGroupShould
    {
        private readonly ISpellGroup fireOffensiveSpellGroup = new FireOffensiveSpellGroup();

        [Fact]
        public void ContainSpells()
        {
            // Then
            Assert.NotEmpty(fireOffensiveSpellGroup.Spells);
        }
    }
}