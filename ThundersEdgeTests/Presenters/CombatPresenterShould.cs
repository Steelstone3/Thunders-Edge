using System;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class CombatPresenterShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly ICombatPresenter combatPresenter;

        public CombatPresenterShould()
        {
            combatPresenter = new CombatPresenter(presenter.Object);
        }

        [Fact]
        public void PrintDeckDefeated()
        {
            // Given
            const string WINNING_PLAYER_NAME = "Bob";
            Mock<IName> name = new();
            name.Setup(n => n.GenericName).Returns(WINNING_PLAYER_NAME);
            presenter.Setup(p => p.Print($"Game over! {WINNING_PLAYER_NAME} wins the match."));

            // When
            combatPresenter.PrintWinningDeck(name.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void PrintDeckDraw()
        {
            // Given
            presenter.Setup(p => p.Print("Game over! Draw."));

            // When
            combatPresenter.PrintDraw();

            // Then
            presenter.VerifyAll();
        }
    }
}