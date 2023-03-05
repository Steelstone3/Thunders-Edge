using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.Spells;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Spells
{
    public class SpellShould
    {
        private const byte REMAINING_CASTING_POINTS = 1;
        private const byte TOTAL_CASTING_POINTS = 2;
        private const byte CASTING_COST = 1;
        private const byte DAMAGE = 1;
        private readonly Mock<IPresenter> presenter = new();
        private readonly Mock<IDamagingSpellCastSystem> damagingSpellCastSystem = new();
        private readonly Mock<ICard> defendingCard = new();
        private readonly ISpell spell;

        public SpellShould()
        {
            spell = new Spell();
            damagingSpellCastSystem.Setup(dscs => dscs.CastSpell(spell, defendingCard.Object));
        }

        [Fact]
        public void CastSpell()
        {
            // When
            spell.CastSpell(damagingSpellCastSystem.Object, defendingCard.Object);

            // Then
            damagingSpellCastSystem.VerifyAll();
        }

        [Fact]
        public void ContainsCastingCost()
        {
            // Then
            Assert.Equal(CASTING_COST, spell.CastingCost);
        }

        [Fact]
        public void ContainsTotalCastingPoints()
        {
            // Then
            Assert.Equal(TOTAL_CASTING_POINTS, spell.RemainingCastingPoints);
        }

        [Fact]
        public void CostCastingPoints()
        {
            // Given
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(spell.Name, (byte)(spell.RemainingCastingPoints - 1)));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);

            // When
            spell.CostCastingPoints(presenter.Object);

            // Then
            presenter.VerifyAll();
            Assert.Equal(REMAINING_CASTING_POINTS, spell.RemainingCastingPoints);
        }

        [Fact]
        public void CostAllCastingPoints()
        {
            // Given
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(spell.Name, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);

            // When
            for (int i = 0; i < byte.MaxValue; i++)
            {
                spell.CostCastingPoints(presenter.Object);
            }

            // Then
            presenter.VerifyAll();
            Assert.Equal(0, spell.RemainingCastingPoints);
        }

        [Fact]
        public void ContainsDamage()
        {
            // Then
            Assert.Equal(DAMAGE, spell.Damage);
        }
    }
}