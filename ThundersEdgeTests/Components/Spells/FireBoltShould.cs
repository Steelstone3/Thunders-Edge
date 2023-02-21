using System.Collections.Generic;
using Moq;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.Spells;
using ThundersEdge.Entities.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
{
    public class FireBoltShould
    {
        private const int CASTING_COST = 2;
        private const int DAMAGE = 25;
        private readonly ISpell spell;

        public FireBoltShould()
        {
            spell = new FireBolt();
        }

        [Fact]
        public void CastASpell()
        {
            // Given
            const int CURRENT_CASTING_POINTS = 2;
            Mock<ICastPointToken> castingPointToken = new();
            castingPointToken.Setup(cpt => cpt.CostCastingToken(CASTING_COST));
            castingPointToken.Setup(cpt => cpt.CastingType).Returns(CastingType.Fire);
            castingPointToken.Setup(cpt => cpt.CastingPoints).Returns(CURRENT_CASTING_POINTS);
            List<ICastPointToken> castPointTokens = new() { castingPointToken.Object };
            Mock<ICard> card = new();
            card.Setup(c => c.TakeDamage(DAMAGE));

            // When
            spell.CastSpell(castPointTokens, card.Object);

            // Then
            castingPointToken.VerifyAll();
            card.VerifyAll();
        }

        [Fact]
        public void RanOutOfTokensToCastSpell()
        {
            // Given
            const int CURRENT_CASTING_POINTS = 1;
            Mock<ICastPointToken> castingPointToken = new();
            castingPointToken.Setup(cpt => cpt.CostCastingToken(CASTING_COST));
            castingPointToken.Setup(cpt => cpt.CastingType).Returns(CastingType.Fire);
            castingPointToken.Setup(cpt => cpt.CastingPoints).Returns(CURRENT_CASTING_POINTS);
            List<ICastPointToken> castPointTokens = new() { castingPointToken.Object };
            Mock<ICard> card = new();
            card.Setup(c => c.TakeDamage(DAMAGE));

            // When
            spell.CastSpell(castPointTokens, card.Object);

            // Then
            castingPointToken.Verify(cpt => cpt.CostCastingToken(CASTING_COST), Times.Never);
            card.Verify(c => c.TakeDamage(DAMAGE),Times.Never);
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("Fire Bolt 🜂", spell.Name.GenericName);
        }

        [Fact]
        public void ContainsCastElement()
        {
            // Then
            Assert.Equal(CastingType.Fire, spell.CastElement);
        }

        [Fact]
        public void ContainsCastPower()
        {
            // Then
            Assert.Equal(CASTING_COST, spell.CastingCost);
        }
    }
}