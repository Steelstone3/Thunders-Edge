using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class GameSetupFactoryShould
    {
        private readonly Mock<IPlayerSetupFactory> playerSetupFactory = new();
        private readonly IGameSetupFactory gameSetupFactory;

        public GameSetupFactoryShould()
        {
            gameSetupFactory = new GameSetupFactory(playerSetupFactory.Object);
        }

        [Fact]
        public void Create()
        {
            // Given
            playerSetupFactory.Setup(psf => psf.Create());

            // When
            IGame game = gameSetupFactory.Create();

            // Then
            playerSetupFactory.VerifyAll();
            Assert.NotNull(game);
        }
    }
}