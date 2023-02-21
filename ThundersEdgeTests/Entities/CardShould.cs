using Moq;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Entities
{
    public class CardShould
    {
        private readonly Mock<ICharacterName> name = new();
        private readonly Mock<IHealth> health = new();
        private readonly Mock<ISpellGroup> spellGroup = new();
        private ICard card;

        public CardShould()
        {
            card = new Card(name.Object, health.Object, spellGroup.Object);
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
            health.Setup(h => h.TakeDamage(25));
            card = new Card(name.Object, health.Object, spellGroup.Object);

            // When
            card.TakeDamage(25);

            // Then
            health.VerifyAll();
        }
    }
}