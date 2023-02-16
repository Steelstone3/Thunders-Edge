using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class SpellGroupFactoryShould
    {
        private readonly Mock<ISpellFactory> spellFactory = new();
        private readonly ISpellGroupFactory spellGroupFactory;

        public SpellGroupFactoryShould()
        {
            spellGroupFactory = new SpellGroupFactory(spellFactory.Object);
        }

        [Fact]
        public void Create()
        {
            // Given
            spellFactory.Setup(sf => sf.Create());

            // When
            ISpellGroup spellGroup = spellGroupFactory.Create();

            // Then
            spellFactory.VerifyAll();
            Assert.NotNull(spellGroup);
        }
    }
}