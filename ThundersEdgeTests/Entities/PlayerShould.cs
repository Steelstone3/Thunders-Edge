using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Models
{
    public class PlayerShould
    {
        private readonly Mock<IName> name = new();
        private readonly Mock<IDeck> deck = new();
        private readonly IPlayer player;

        public PlayerShould()
        {
            player = new Player(name.Object, deck.Object);
        }

        [Fact]
        public void ContainsPlayerName()
        {
            // Then
            Assert.NotNull(player.Name);
        }

        [Fact]
        public void ContainsDeck()
        {
            // Then
            Assert.NotNull(player.Deck);
        }
    }
}