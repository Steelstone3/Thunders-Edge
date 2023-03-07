using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Entities
{
    public class DeckShould
    {
        private readonly Mock<IEnumerable<ICard>> cards = new();
        private IDeck deck;

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

        [Fact]
        public void DetermineIsDeckStillInPlay()
        {
            // Given
            Mock<ICard> card = new();
            card.Setup(c => c.IsCardStillInPlay()).Returns(true);
            Mock<ICard> anotherCard = new();
            anotherCard.Setup(c => c.IsCardStillInPlay()).Returns(false);
            List<ICard> cards = new() { card.Object, card.Object, anotherCard.Object };
            deck = new Deck(cards);

            // When
            bool isDeckStillInPlay = deck.IsDeckStillInPlay();

            // Then
            card.VerifyAll();
            Assert.True(isDeckStillInPlay);
        }

        [Fact]
        public void DetermineIsDeckStillInPlayButACardIsNot()
        {
            // Given
            Mock<ICard> card = new();
            card.Setup(c => c.IsCardStillInPlay()).Returns(false);
            List<ICard> cards = new() { card.Object, card.Object };
            deck = new Deck(cards);

            // When
            bool isDeckStillInPlay = deck.IsDeckStillInPlay();

            // Then
            card.VerifyAll();
            Assert.False(isDeckStillInPlay);
        }
    }
}