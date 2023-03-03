using System.Collections.Generic;
using Microsoft.Win32;
using Moq;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
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
            presenter.Setup(p => p.Print($"{FIRST_NAME} {SURNAME} took [red]{DAMAGE}[/] damage [red]{CURRENT_HEALTH}[/]/[red]{MAXIMUM_HEALTH}[/]"));

            // When
            deckPresenter.PrintCardTakingDamage(DAMAGE, characterName.Object, health.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void PrintRemainingCastingToken()
        {
            // Given
            const string SPELL_CASTING_TYPE_NAME = "Fire";
            const int REMAINING_CASTING_POINTS = 10;
            Mock<IName> name = new();
            name.Setup(n => n.GenericName).Returns(SPELL_CASTING_TYPE_NAME);
            presenter.Setup(p => p.Print($"Casting Type: {SPELL_CASTING_TYPE_NAME}\nCasting Points Remaining: {REMAINING_CASTING_POINTS}"));

            // When
            deckPresenter.PrintRemainingCastingToken(name.Object, REMAINING_CASTING_POINTS);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void PrintCardSummary()
        {
            // Given
            const string FIRST_NAME = "Bob";
            const string SURNAME = "Spencer";
            const int CURRENT_HEALTH = 90;
            const int MAXIMUM_HEALTH = 100;
            const string SPELL_NAME = "Fire Bolt";
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
            Mock<ICard> card = new();
            card.Setup(c => c.Name).Returns(characterName.Object);
            card.Setup(c => c.Health).Returns(health.Object);
            card.Setup(c => c.SpellGroup).Returns(spellGroup.Object);
            string expectedSummary =$"{FIRST_NAME} {SURNAME} | [red]{CURRENT_HEALTH}[/]/[red]{MAXIMUM_HEALTH}[/] | | {SPELL_NAME}   {SPELL_NAME}   {SPELL_NAME} | |";

            // When
            var result = deckPresenter.PrintCardSummary(card.Object);

            // Then
            Assert.Equal(expectedSummary, result);
        }
    }
}