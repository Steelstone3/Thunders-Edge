using BubblesDivePlanner.Presenters;
using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class SpellCastingPresenterShould
    {
        private readonly string playerName = "Alfie";
        private readonly Mock<IDeck> deck = new();
        private readonly Mock<IPresenter> presenter = new();
        private readonly ISpellCastingPresenter spellCastingPresenter;

        public SpellCastingPresenterShould()
        {
            spellCastingPresenter = new SpellCastingPresenter(presenter.Object);
        }

        [Fact]
        public void SelectAttackingCard()
        {
            // Given
            presenter.Setup(p => p.Print($"{playerName}'s Turn"));
            presenter.Setup(p => p.GetCardFromDeck("Select Casting Card:", deck.Object));

            // When
            spellCastingPresenter.SelectAttackingCard(playerName, deck.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void SelectDefendingCard()
        {
            // Given
            presenter.Setup(p => p.Print($"{playerName}'s Turn"));
            presenter.Setup(p => p.GetCardFromDeck("Select Target Card:", deck.Object));

            // When
            spellCastingPresenter.SelectDefendingCard(playerName, deck.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void SelectSpellToCast()
        {
            // Given
            Mock<ICard> card = new();
            presenter.Setup(p => p.GetSpellFromCard(card.Object));

            // When
            spellCastingPresenter.SelectSpell(card.Object);

            // Then
            presenter.VerifyAll();
        }
    }
}