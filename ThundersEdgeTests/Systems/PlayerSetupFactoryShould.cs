using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class PlayerSetupFactoryShould
    {
        private readonly Mock<ICharacterPresenter> characterPresenter = new();
        private readonly Mock<IDeckFactory> deckFactory = new();
        private readonly Mock<IAllSpellTokenFactory> spellTokenFactory = new();
        private readonly IPlayerSetupFactory playerSetupFactory;

        public PlayerSetupFactoryShould()
        {
            playerSetupFactory = new PlayerSetupFactory(characterPresenter.Object, deckFactory.Object, spellTokenFactory.Object);
        }

        [Fact]
        public void CreateAPlayer()
        {
            // Given
            characterPresenter.Setup(cp => cp.AskCharacterName());
            deckFactory.Setup(df => df.Create()).Returns(new Mock<IDeck>().Object);
            spellTokenFactory.Setup(pdf => pdf.Create()).Returns(new Mock<IAllCastPointTokens>().Object);

            // When
            IPlayer player = playerSetupFactory.Create();

            // Then
            characterPresenter.VerifyAll();
            deckFactory.VerifyAll();
            spellTokenFactory.VerifyAll();
            Assert.NotNull(player.Deck);
            Assert.NotNull(player.PointsTokens);
        }
    }
}