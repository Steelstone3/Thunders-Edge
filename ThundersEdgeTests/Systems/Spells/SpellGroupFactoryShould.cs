using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class SpellGroupFactoryShould
    {
        private readonly ISpellGroupFactory spellGroupFactory;

        public SpellGroupFactoryShould()
        {
            spellGroupFactory = new SpellGroupFactory();
        }

        [Fact(Skip = "Implement a spell group, implement a spell groups similar to the random character name system, then return a random spell group")]
        public void Create()
        {
            // When
            ISpellGroup spellGroup = spellGroupFactory.Create();

            // Then
            Assert.NotNull(spellGroup);
            Assert.NotEmpty(spellGroup.Spells);
        }
    }
}