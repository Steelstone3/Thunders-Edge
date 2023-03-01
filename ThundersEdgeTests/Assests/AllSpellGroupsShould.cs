using ThundersEdge.Assests;
using ThundersEdge.Assests.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Assests
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