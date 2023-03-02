using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Services;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Services
{
    public class GameServiceShould
    {
        private readonly Mock<IGame> game = new();
        private readonly Mock<ICombatSystem> spellCastingSystem = new();
        private readonly Mock<IGameSetupFactory> gameSetupFactory = new();
        private readonly IGameService gameService;

        public GameServiceShould()
        {
            gameService = new GameService(gameSetupFactory.Object, spellCastingSystem.Object);
        }

        [Fact]
        public void SetupGame()
        {
            // Given
            gameSetupFactory.Setup(gsf => gsf.Create()).Returns(game.Object);
            spellCastingSystem.Setup(scs => scs.Start(game.Object));

            // When
            gameService.Run();

            // Then
            gameSetupFactory.VerifyAll();
            spellCastingSystem.VerifyAll();
        }
    }
}