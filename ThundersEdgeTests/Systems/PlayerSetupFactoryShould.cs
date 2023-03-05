using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class PlayerSetupFactoryShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly Mock<ICharacterPresenter> characterPresenter = new();
        private readonly Mock<IDeckFactory> deckFactory = new();
        private readonly IPlayerSetupFactory playerSetupFactory;

        public PlayerSetupFactoryShould()
        {
            playerSetupFactory = new PlayerSetupFactory(presenter.Object, deckFactory.Object);
        }

        [Fact]
        public void CreateAPlayer()
        {
            // Given
            characterPresenter.Setup(cp => cp.AskPlayerName());
            presenter.Setup(p => p.CharacterPresenter).Returns(characterPresenter.Object);
            deckFactory.Setup(df => df.Create()).Returns(new Mock<IDeck>().Object);

            // When
            IPlayer player = playerSetupFactory.Create();

            // Then
            presenter.VerifyAll();
            deckFactory.VerifyAll();
            Assert.NotNull(player.Deck);
        }
    }
}