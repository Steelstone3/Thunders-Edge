using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class DeckPresenterShould
    {
        private readonly Mock<ICharacterName> characterName = new();
        private readonly Mock<IHealth> health = new();
        private readonly Mock<IPresenter> presenter = new();
        private readonly IDeckPresenter deckPresenter;

        public DeckPresenterShould()
        {
            deckPresenter = new DeckPresenter(presenter.Object);
        }

        [Fact]
        public void DisplayCardTakingDamage()
        {
            // Given
            const string FIRST_NAME = "Bob";
            const string SURNAME = "Spencer";
            const byte DAMAGE = 10;
            const int CURRENT_HEALTH = 90;
            const int MAXIMUM_HEALTH = 100;
            characterName.Setup(n => n.FirstName).Returns(FIRST_NAME);
            characterName.Setup(n => n.Surname).Returns(SURNAME);
            health.Setup(h => h.CurrentHealth).Returns(CURRENT_HEALTH);
            health.Setup(h => h.MaximumHealth).Returns(MAXIMUM_HEALTH);
            presenter.Setup(p => p.Print($"{FIRST_NAME} {SURNAME} took {DAMAGE} damage [red]{CURRENT_HEALTH}[/]/[red]{MAXIMUM_HEALTH}[/]"));

            // When
            deckPresenter.PrintCardTakingDamage(DAMAGE, characterName.Object, health.Object);

            // Then
            presenter.VerifyAll();
        }
    }
}