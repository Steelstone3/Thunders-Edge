using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.SpellGroups;
using Xunit;

namespace ThundersEdgeTests.Components.SpellGroups
{
    public class AllSpellGroupsShould
    {
        private readonly IAllSpellGroups allSpellGroups = new AllSpellGroups();

        [Fact]
        public void ContainSpellGroups()
        {
            // Then
            Assert.NotEmpty(allSpellGroups.SpellGroups);
        }
    }
}