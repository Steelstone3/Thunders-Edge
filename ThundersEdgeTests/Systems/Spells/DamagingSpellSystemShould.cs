using System;
using System.Collections.Generic;
using Moq;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class DamagingSpellSystemShould
    {
        private List<ICastPointToken> castPointTokens;
        private readonly Mock<ICastPointToken> castPointToken = new();
        private readonly Mock<ICard> card = new();
        private readonly Mock<ISpell> spell = new();
        private readonly IDamagingSpellCastSystem damagingSpellCastSystem;

        public DamagingSpellSystemShould()
        {
            spell.Setup(s => s.Damage).Returns(10);
            spell.Setup(s => s.CastingCost).Returns(2);
            spell.Setup(s => s.CastElement).Returns(CastingType.Fire);
            
                        castPointToken.Setup(cpt => cpt.CostCastingToken(spell.Object.CastingCost));
            castPointToken.Setup(cpt => cpt.CastingType).Returns(CastingType.Fire);

            damagingSpellCastSystem = new DamagingSpellCastSystem();
        }

        [Fact]
        public void CastASpell()
        {
            // Given
            const int CURRENT_CASTING_POINTS = 2;
            castPointToken.Setup(cpt => cpt.CastingPoints).Returns(CURRENT_CASTING_POINTS);
            castPointTokens = new() { castPointToken.Object };
            Mock<ICard> card = new();
            card.Setup(c => c.TakeDamage(spell.Object.Damage));

            // When
            damagingSpellCastSystem.CastSpell(spell.Object, castPointTokens, card.Object);

            // Then
            castPointToken.VerifyAll();
            card.VerifyAll();
        }


        [Fact]
        public void RanOutOfTokensToCastSpell()
        {
            // Given
            const int CURRENT_CASTING_POINTS = 1;
            castPointToken.Setup(cpt => cpt.CastingPoints).Returns(CURRENT_CASTING_POINTS);
            castPointTokens = new() { castPointToken.Object };
            card.Setup(c => c.TakeDamage(spell.Object.Damage));

            // When
            damagingSpellCastSystem.CastSpell(spell.Object, castPointTokens, card.Object);

            // Then
            castPointToken.Verify(cpt => cpt.CostCastingToken(spell.Object.CastingCost), Times.Never);
            card.Verify(c => c.TakeDamage(spell.Object.Damage), Times.Never);
        }
    }
}