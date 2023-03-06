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
        private readonly Mock<IName> name = new();
        private readonly Mock<IDeckPresenter> deckPresenter = new();
        private readonly Mock<IPresenter> presenter = new();
        private IDeck deck;

        public DeckShould()
        {
            deck = new Deck(cards.Object);

            deckPresenter.Setup(dp => dp.PrintDeckDefeated(name.Object));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
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
            bool isDeckStillInPlay = deck.IsDeckStillInPlay(presenter.Object, name.Object);

            // Then
            card.VerifyAll();
            deckPresenter.Verify(dp => dp.PrintDeckDefeated(name.Object),Times.Never);
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
            bool isDeckStillInPlay = deck.IsDeckStillInPlay(presenter.Object, name.Object);

            // Then
            card.VerifyAll();
            presenter.VerifyAll();
            Assert.False(isDeckStillInPlay);
        }
    }
}