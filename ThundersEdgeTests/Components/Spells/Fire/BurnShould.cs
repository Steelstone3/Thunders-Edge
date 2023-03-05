using Moq;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.Spells.Fire;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Spells.Fire
{
    public class BurnShould
    {
        private readonly Mock<IDamagingSpellCastSystem> damagingSpellCastSystem = new();
        private readonly Mock<IAllCastPointTokens> allCastPointTokens = new();
        private readonly Mock<ICard> defendingCard = new();
        private readonly ISpell spell;

        public BurnShould()
        {
            spell = new Burn();
            damagingSpellCastSystem.Setup(dscs => dscs.CastSpell(spell, allCastPointTokens.Object, defendingCard.Object));
        }

        [Fact]
        public void CastSpell()
        {
            // When
            spell.CastSpell(damagingSpellCastSystem.Object, allCastPointTokens.Object, defendingCard.Object);

            // Then
            damagingSpellCastSystem.VerifyAll();
        }

        [Fact]
        public void ContainsASpellName()
        {
            // Then
            Assert.Equal("[darkorange]Burn 🜂[/]", spell.Name.GenericName);
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
            Assert.Equal(1, spell.CastingCost);
        }

        [Fact]
        public void ContainsDamage()
        {
            // Then
            Assert.Equal(10, spell.Damage);
        }
    }
}