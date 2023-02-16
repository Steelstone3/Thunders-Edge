using System.Collections.Generic;
using Moq;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Entities
{
    public class GameShould
    {
        private readonly Mock<IEnumerable<IPlayer>> players = new();
        private readonly IGame game;

        public GameShould()
        {
            game = new Game(players.Object);
        }

        [Fact]
        public void ContainsPlayers()
        {
            // Then
            Assert.NotNull(game.Players);
        }
    }
}