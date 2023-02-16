using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class PlayerSetupFactoryShould
    {
        private readonly Mock<IDeckFactory> deckFactory = new();
        private readonly Mock<ISpellTokenFactory> spellTokenFactory = new();
        private readonly IPlayerSetupFactory playerSetupFactory;

        public PlayerSetupFactoryShould()
        {
            playerSetupFactory = new PlayerSetupFactory(deckFactory.Object, spellTokenFactory.Object);
        }

        [Fact]
        public void CreateAPlayer()
        {
            // Given
            deckFactory.Setup(df => df.Create()).Returns(new Mock<IDeck>().Object);
            spellTokenFactory.Setup(pdf => pdf.Create()).Returns(new Mock<IEnumerable<ICastPointToken>>().Object);

            // When
            IPlayer player = playerSetupFactory.Create();

            // Then
            deckFactory.VerifyAll();
            spellTokenFactory.VerifyAll();
            Assert.NotNull(player.Deck);
            Assert.NotNull(player.PointsTokens);
        }
    }
}