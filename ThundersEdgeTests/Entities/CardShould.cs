using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Entities
{
    public class CardShould
    {
        private readonly Mock<IDeckPresenter> deckPresenter = new();
        private readonly Mock<IPresenter> presenter = new();
        private readonly Mock<ICharacterName> name = new();
        private readonly Mock<IHealth> health = new();
        private readonly Mock<ISpellGroup> spellGroup = new();
        private ICard card;

        public CardShould()
        {
            card = new Card(presenter.Object, name.Object, health.Object, spellGroup.Object);
        }

        [Fact]
        public void ContainsName()
        {
            // Then
            Assert.NotNull(card.Name);
        }

        [Fact]
        public void ContainsHealth()
        {
            // Then
            Assert.NotNull(card.Health);
        }

        [Fact]
        public void ContainsSpellGroup()
        {
            // Then
            Assert.NotNull(card.SpellGroup);
        }

        [Fact]
        public void TakeDamage()
        {
            // Given
            const int DAMAGE = 25;
            health.Setup(h => h.TakeDamage(DAMAGE));
            deckPresenter.Setup(dp => dp.PrintCardTakingDamage(DAMAGE, name.Object, health.Object));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            card = new Card(presenter.Object, name.Object, health.Object, spellGroup.Object);

            // When
            card.TakeDamage(DAMAGE);

            // Then
            health.VerifyAll();
            presenter.VerifyAll();
        }
    }
}