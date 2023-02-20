using System.Collections.Generic;
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
        private readonly Mock<IPlayer> player = new();
        private readonly Mock<ISpellCastingSystem> spellCastingSystem = new();
        private readonly Mock<IGameSetupFactory> gameSetupFactory = new();
        private readonly IGameService gameService;

        public GameServiceShould()
        {
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, player.Object });
            gameService = new GameService(gameSetupFactory.Object, spellCastingSystem.Object);
        }

        [Fact]
        public void SetupGame()
        {
            // Given
            gameSetupFactory.Setup(gsf => gsf.Create()).Returns(game.Object);
            spellCastingSystem.Setup(scs => scs.CastSpell(player.Object, player.Object));

            // When
            gameService.Run();

            // Then
            gameSetupFactory.VerifyAll();
            spellCastingSystem.VerifyAll();
        }
    }
}