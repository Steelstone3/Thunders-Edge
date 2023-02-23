using Moq;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class DamagingSpellSystemShould
    {
        private readonly Mock<IAllCastPointTokens> allCastPointTokens = new();
        private readonly Mock<ICastPointToken> castPointToken = new();
        private readonly Mock<ICard> card = new();
        private readonly Mock<ISpell> spell = new();
        private readonly IDamagingSpellCastSystem damagingSpellCastSystem;

        public DamagingSpellSystemShould()
        {
            spell.Setup(s => s.CastElement).Returns(CastingType.Fire);
            allCastPointTokens.Setup(acpt => acpt.GetCastPointTokenOfType(CastingType.Fire)).Returns(castPointToken.Object);

            damagingSpellCastSystem = new DamagingSpellCastSystem();
        }

        [Fact]
        public void CastASpell()
        {
            // // Given
            const int CURRENT_CASTING_POINTS = 2;
            const int DAMAGE = 25;
            spell.Setup(s => s.CastingCost).Returns(CURRENT_CASTING_POINTS);
            spell.Setup(s => s.Damage).Returns(DAMAGE);
            castPointToken.Setup(cpt => cpt.CastingPoints).Returns(CURRENT_CASTING_POINTS);
            castPointToken.Setup(cpt => cpt.CostCastingToken(spell.Object.CastingCost));
            card.Setup(c => c.TakeDamage(spell.Object.Damage));

            // When
            damagingSpellCastSystem.CastSpell(spell.Object, allCastPointTokens.Object, card.Object);

            // Then
            allCastPointTokens.Verify(acpt => acpt.GetCastPointTokenOfType(CastingType.Fire));
            castPointToken.Verify(cpt => cpt.CostCastingToken(CURRENT_CASTING_POINTS));
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
            spell.Setup(s => s.Damage).Returns(DAMAGE);
            castPointToken.Setup(cpt => cpt.CastingPoints).Returns(CURRENT_CASTING_POINTS);
            castPointToken.Setup(cpt => cpt.CostCastingToken(spell.Object.CastingCost));
            card.Setup(c => c.TakeDamage(spell.Object.Damage));

            // When
            damagingSpellCastSystem.CastSpell(spell.Object, allCastPointTokens.Object, card.Object);

            // Then
            allCastPointTokens.Verify(acpt => acpt.GetCastPointTokenOfType(CastingType.Fire));
            castPointToken.Verify(cpt => cpt.CostCastingToken(CURRENT_CASTING_POINTS), Times.Never);
            card.Verify(c => c.TakeDamage(spell.Object.Damage), Times.Never);
        }
    }
}