using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.SpellGroups;
using Xunit;

namespace ThundersEdgeTests.Components.SpellGroups
{
    public class SpellGroupShould
    {
        private readonly Mock<IEnumerable<ISpell>> spells = new();
        private readonly ISpellGroup spellGroup;

        public SpellGroupShould()
        {
            spellGroup = new SpellGroup(spells.Object);
        }

        [Fact]
        public void ContainSpells()
        {
            // Then
            Assert.NotNull(spellGroup.Spells);
        }
    }
}