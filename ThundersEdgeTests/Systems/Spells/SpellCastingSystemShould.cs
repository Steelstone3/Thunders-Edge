using System.Collections.Generic;
using System.Linq;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class SpellCastingSystemShould
    {
        private readonly Mock<ISpellCastingPresenter> spellCastingPresenter = new();
        private readonly Mock<IPresenter> presenter = new();
        private readonly Mock<IPlayer> player = new();
        private readonly Mock<ICard> card = new();
        private readonly Mock<IDamagingSpellCastSystem> damagingSpellCastSystem = new();
        private readonly Mock<ISpell> spell = new();
        private readonly ISpellCastingSystem spellCastingSystem;

        public SpellCastingSystemShould()
        {
            spellCastingSystem = new SpellCastingSystem(presenter.Object, damagingSpellCastSystem.Object);
        }

        [Fact]
        public void CastASpell()
        {
            // Given
            SetupPlayerStub(true);
            spellCastingPresenter.Setup(scp => scp.PrintPlayerTurn(player.Object.Name));
            spellCastingPresenter.Setup(scp => scp.SelectAttackingCard(player.Object.Deck)).Returns(player.Object.Deck.Cards.ToList()[0]);
            spellCastingPresenter.Setup(scp => scp.SelectDefendingCard(player.Object.Deck)).Returns(player.Object.Deck.Cards.ToList()[0]);
            spellCastingPresenter.Setup(scp => scp.SelectSpell(player.Object.Deck.Cards.ToList()[0])).Returns(player.Object.Deck.Cards.ToList()[0].SpellGroup.Spells.ToList()[0]);
            presenter.Setup(p => p.SpellCastingPresenter).Returns(spellCastingPresenter.Object);
            spell.Setup(s => s.CastSpell(damagingSpellCastSystem.Object, card.Object));

            // When
            var isSpellCast = spellCastingSystem.CastSpell(player.Object, player.Object);

            // Then
            presenter.VerifyAll();
            spell.VerifyAll();
            Assert.True(isSpellCast);
        }

        [Fact]
        public void CastASpellWithNoPlayableDeck()
        {
            // Given
            SetupPlayerStub(false);
            spellCastingPresenter.Setup(scp => scp.PrintPlayerTurn(player.Object.Name));
            spellCastingPresenter.Setup(scp => scp.SelectAttackingCard(player.Object.Deck)).Returns(player.Object.Deck.Cards.ToList()[0]);
            spellCastingPresenter.Setup(scp => scp.SelectDefendingCard(player.Object.Deck)).Returns(player.Object.Deck.Cards.ToList()[0]);
            spellCastingPresenter.Setup(scp => scp.SelectSpell(player.Object.Deck.Cards.ToList()[0])).Returns(player.Object.Deck.Cards.ToList()[0].SpellGroup.Spells.ToList()[0]);
            presenter.Setup(p => p.SpellCastingPresenter).Returns(spellCastingPresenter.Object);
            spell.Setup(s => s.CastSpell(damagingSpellCastSystem.Object, card.Object));

            // When
            var isSpellCast = spellCastingSystem.CastSpell(player.Object, player.Object);

            // Then
            presenter.Verify(p => p.SpellCastingPresenter, Times.Never);
            spell.Verify(s => s.CastSpell(damagingSpellCastSystem.Object, card.Object), Times.Never);
            Assert.False(isSpellCast);
        }

        private void SetupPlayerStub(bool isDeckStillInPlay)
        {
            Mock<IName> name = new();
            Mock<IDeck> deck = new();
            Mock<ISpellGroup> spellGroup = new();

            name.Setup(n => n.GenericName).Returns("Bob");
            spellGroup.Setup(sg => sg.Spells).Returns(new List<ISpell>() { spell.Object });
            card.Setup(c => c.SpellGroup).Returns(spellGroup.Object);
            deck.Setup(d => d.Cards).Returns(new List<ICard>() { card.Object });
            deck.Setup(d => d.IsDeckStillInPlay()).Returns(isDeckStillInPlay);
            player.Setup(p => p.Deck).Returns(deck.Object);
            player.Setup(p => p.Name).Returns(name.Object);
        }
    }
}