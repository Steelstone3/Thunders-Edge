using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class SpellGroupFactoryShould
    {
        private readonly Mock<IRandomSpellGroupSystem> randomSpellGroupSystem = new();
        private readonly ISpellGroupFactory spellGroupFactory;

        public SpellGroupFactoryShould()
        {
            Mock<ISpellGroup> spellGroup = new();
            randomSpellGroupSystem.Setup(rsgs => rsgs.RandomSpellGroup()).Returns(spellGroup.Object);
            spellGroupFactory = new SpellGroupFactory(randomSpellGroupSystem.Object);
        }

        [Fact]
        public void Create()
        {
            // When
            ISpellGroup spellGroup = spellGroupFactory.Create();

            // Then
            randomSpellGroupSystem.VerifyAll();
            Assert.NotNull(spellGroup);
        }
    }
}