using System.Collections.Generic;
using Moq;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Entities
{
    public class DeckShould
    {
        private readonly Mock<IEnumerable<ICard>> cards = new();
        private readonly IDeck deck;

        public DeckShould()
        {
            deck = new Deck(cards.Object);
        }

        [Fact]
        public void ContainCards()
        {
            // Then
            Assert.NotNull(deck.Cards);
        }
    }
}