using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class PresenterShould
    {
        private readonly IPresenter presenter = new Presenter();

        [Fact]
        public void CatchInvalidInputForGetString()
        {
            // Then
            Assert.Throws<InvalidOperationException>(() => presenter.GetString("[bbb]Gerald[/]"));
        }

        [Fact]
        public void ContainsDeckPresenter()
        {
            // Then
            Assert.NotNull(presenter.DeckPresenter);
        }

        [Fact]
        public void ContainsSpellCastingPresenter()
        {
            // Then
            Assert.NotNull(presenter.SpellCastingPresenter);
        }

        [Fact]
        public void ContainsCharacterPresenter()
        {
            // Then
            Assert.NotNull(presenter.CharacterPresenter);
        }

        [Fact]
        public void ContainsCombatPresenter()
        {
            // Then
            Assert.NotNull(presenter.CombatPresenter);
        }

        [Fact]
        public void GetCardsFromDeckWhenCardsAreAllOutOfPlay()
        {
            // Given
            Mock<IDeck> deck = new();
            deck.Setup(d => d.Cards).Returns(new List<ICard>());

            // When
            ICard card = presenter.GetCardFromDeck(null, null, deck.Object);

            // Then
            Assert.Null(card);
        }

        [Fact]
        public void GetCardsFromDeckWhenCardsIsNull()
        {
            // Given
            Mock<IDeck> deck = new();

            // When
            ICard card = presenter.GetCardFromDeck(null, null, deck.Object);

            // Then
            Assert.Null(card);
        }

        [Fact]
        public void GetSpellFromCardWhenNoCardSelected()
        {
            // When
            ISpell spell = presenter.GetSpellFromCard(null);

            // Then
            Assert.Null(spell);
        }
    }
}