using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Casting;
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

        [Fact]
        public void GetSummary()
        {
            // Given
            const string FIRST_NAME = "Bob";
            const string SURNAME = "Spencer";
            const int CURRENT_HEALTH = 90;
            const int MAXIMUM_HEALTH = 100;
            const string SPELL_NAME = "Fire Bolt";
            string expectedSummary = $"{FIRST_NAME} {SURNAME} | [red]{CURRENT_HEALTH}[/]/[red]{MAXIMUM_HEALTH}[/] | | {SPELL_NAME}   {SPELL_NAME}   {SPELL_NAME} | |";
            Mock<ICharacterName> characterName = new();
            characterName.Setup(cn => cn.FirstName).Returns(FIRST_NAME);
            characterName.Setup(cn => cn.Surname).Returns(SURNAME);
            Mock<IHealth> health = new();
            health.Setup(h => h.CurrentHealth).Returns(CURRENT_HEALTH);
            health.Setup(h => h.MaximumHealth).Returns(MAXIMUM_HEALTH);
            Mock<IName> name = new();
            name.Setup(n => n.GenericName).Returns(SPELL_NAME);
            Mock<ISpell> spell = new();
            spell.Setup(s => s.Name).Returns(name.Object);
            spell.Setup(s => s.CastElement).Returns(CastingType.Fire);
            Mock<ISpellGroup> spellGroup = new();
            spellGroup.Setup(sg => sg.Spells).Returns(new List<ISpell>() { spell.Object, spell.Object, spell.Object });
            card = new Card(presenter.Object, characterName.Object, health.Object, spellGroup.Object);

            // When
            string result = card.GetSummary();

            // Then
            Assert.Equal(expectedSummary, result);
        }
    }
}