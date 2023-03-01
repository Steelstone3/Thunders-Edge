using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class SpellCastingPresenterShould
    {
        private readonly Mock<IDeck> deck = new();
        private readonly Mock<IPresenter> presenter = new();
        private readonly ISpellCastingPresenter spellCastingPresenter;

        public SpellCastingPresenterShould()
        {
            spellCastingPresenter = new SpellCastingPresenter(presenter.Object);
        }

        [Fact]
        public void PrintPlayerTurn()
        {
            // Given
            Mock<IName> name = new();
            name.Setup(n => n.GenericName).Returns("Alfie");
            presenter.Setup(p => p.Print($"\n\n\n{name.Object.GenericName}'s Turn\n"));
        
            // When
            spellCastingPresenter.PrintPlayerTurn(name.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void SelectAttackingCard()
        {
            // Given
            presenter.Setup(p => p.GetCardFromDeck("Select Casting Card:", "Casting Card Selected:", deck.Object));

            // When
            spellCastingPresenter.SelectAttackingCard(deck.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void SelectDefendingCard()
        {
            // Given
            presenter.Setup(p => p.GetCardFromDeck("Select Target Card:", "Target Card Selected:", deck.Object));

            // When
            spellCastingPresenter.SelectDefendingCard(deck.Object);

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