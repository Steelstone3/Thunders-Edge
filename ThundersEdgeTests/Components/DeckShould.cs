using System.Collections.Generic;
using Moq;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
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