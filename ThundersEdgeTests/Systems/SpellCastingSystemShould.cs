using System.Collections.Generic;
using System.Linq;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class SpellCastingSystemShould
    {
        private readonly Mock<ISpellCastingPresenter> spellCastingPresenter = new();
        private readonly Mock<IPlayer> player = new();
        private readonly Mock<ICard> card = new();
        private readonly Mock<ISpell> spell = new();
        private readonly ISpellCastingSystem spellCastingSystem;

        public SpellCastingSystemShould()
        {
            SetupPlayerStub();
            spellCastingSystem = new SpellCastingSystem(spellCastingPresenter.Object);
        }

        [Fact]
        public void CastASpell()
        {
            // Given
            spellCastingPresenter.Setup(scp => scp.SelectAttackingCard(player.Object.Deck)).Returns(player.Object.Deck.Cards.ToList()[0]);
            spellCastingPresenter.Setup(scp => scp.SelectDefendingCard(player.Object.Deck)).Returns(player.Object.Deck.Cards.ToList()[0]);
            spellCastingPresenter.Setup(scp => scp.SelectSpell(player.Object.Deck.Cards.ToList()[0])).Returns(player.Object.Deck.Cards.ToList()[0].SpellGroup.Spells.ToList()[0]);
            spell.Setup(s => s.CastSpell(player.Object.PointsTokens, card.Object));

            // When
            spellCastingSystem.CastSpell(player.Object, player.Object);

            // Then
            spellCastingPresenter.VerifyAll();
        }

        private void SetupPlayerStub()
        {
            Mock<IDeck> deck = new();
            Mock<ISpellGroup> spellGroup = new();

            spellGroup.Setup(sg => sg.Spells).Returns(new List<ISpell>() { spell.Object });
            card.Setup(c => c.SpellGroup).Returns(spellGroup.Object);
            deck.Setup(d => d.Cards).Returns(new List<ICard>() { card.Object });
            player.Setup(p => p.Deck).Returns(deck.Object);

            Mock<ICastPointToken> castPointToken = new();

            player.Setup(pt => pt.PointsTokens).Returns(new List<ICastPointToken>() { castPointToken.Object });
        }
    }
}