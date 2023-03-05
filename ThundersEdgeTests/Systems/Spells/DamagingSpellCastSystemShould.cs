using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class DamagingSpellCastSystemShould
    {
        private readonly Mock<ICard> card = new();
        private readonly Mock<ISpell> spell = new();
        private readonly Mock<IPresenter> presenter = new();
        private readonly IDamagingSpellCastSystem damagingSpellCastSystem;

        public DamagingSpellCastSystemShould()
        {
            damagingSpellCastSystem = new DamagingSpellCastSystem(presenter.Object);
        }

        [Fact]
        public void CastASpell()
        {
            // // Given
            const int SPELL_CASTING_POINTS = 2;
            const int CURRENT_CASTING_POINTS = 2;
            const int DAMAGE = 25;
            spell.Setup(s => s.CastingCost).Returns(SPELL_CASTING_POINTS);
            spell.Setup(s => s.RemainingCastingPoints).Returns(CURRENT_CASTING_POINTS);
            spell.Setup(s => s.Damage).Returns(DAMAGE);
            spell.Setup(s => s.CostCastingPoints(presenter.Object));
            card.Setup(c => c.TakeDamage(spell.Object.Damage));

            // When
            damagingSpellCastSystem.CastSpell(spell.Object, card.Object);

            // Then
            spell.VerifyAll();
            card.VerifyAll();
        }

        [Fact]
        public void RanOutOfTokensToCastSpell()
        {
            // Given
            const int SPELL_CASTING_POINTS = 2;
            const int CURRENT_CASTING_POINTS = 1;
            const int DAMAGE = 25;
            spell.Setup(s => s.CastingCost).Returns(SPELL_CASTING_POINTS);
            spell.Setup(s => s.RemainingCastingPoints).Returns(CURRENT_CASTING_POINTS);
            spell.Setup(s => s.Damage).Returns(DAMAGE);
            spell.Setup(s => s.CostCastingPoints(presenter.Object));
            card.Setup(c => c.TakeDamage(spell.Object.Damage));

            // When
            damagingSpellCastSystem.CastSpell(spell.Object, card.Object);

            // Then
            spell.Verify(s => s.CostCastingPoints(presenter.Object), Times.Never);
            card.Verify(c => c.TakeDamage(spell.Object.Damage), Times.Never);
        }
    }
}