using System.Collections.Generic;
using System.Linq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.SpellGroups;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class RandomSpellGroupSystemShould
    {
        private readonly IAllSpellGroups allSpellGroups = new AllSpellGroups();
        private readonly IRandomSpellGroupSystem randomSpellGroupSystem;

        public RandomSpellGroupSystemShould()
        {
            randomSpellGroupSystem = new RandomSpellGroupSystem(allSpellGroups);
        }

        [Fact]
        public void RandomlySelectASpellGroup()
        {
            // Given
            IEnumerable<ISpellGroup> spellGroups = allSpellGroups.SpellGroups;

            // When
            ISpellGroup spellGroup = randomSpellGroupSystem.RandomSpellGroup();

            // Then
            Assert.Contains(spellGroup, spellGroups);
        }
    }
}