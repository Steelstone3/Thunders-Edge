using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Services;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Services
{
    public class GameServiceShould
    {
        private readonly Mock<IGameSetupFactory> gameSetupFactory = new();
        private readonly IGameService gameService;

        public GameServiceShould()
        {
            gameService = new GameService(gameSetupFactory.Object);
        }

        [Fact]
        public void SetupGame()
        {
            // Given
            gameSetupFactory.Setup(gsf => gsf.Create()).Returns(It.IsAny<IGame>);

            // When
            gameService.Run();

            // Then
            gameSetupFactory.VerifyAll();
        }
    }
}