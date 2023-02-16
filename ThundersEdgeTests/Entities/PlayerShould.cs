using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Models
{
    public class PlayerShould
    {
        private readonly Mock<IDeck> deck = new();
        private readonly Mock<IEnumerable<ICastPointToken>> pointsTokens = new();
        private readonly IPlayer player;

        public PlayerShould()
        {
            player = new Player(deck.Object, pointsTokens.Object);
        }

        [Fact]
        public void ContainsDeck()
        {
            // Then
            Assert.NotNull(player.Deck);
        }

        [Fact]
        public void ContainsPointsDeck()
        {
            // Then
            Assert.NotNull(player.PointsTokens);
        }
    }
}