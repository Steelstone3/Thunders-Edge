using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Casting
{
    public class CastPointTokenShould
    {
        private readonly CastingType castingType = CastingType.Air;
        private readonly ICastPointToken castPointToken;

        public CastPointTokenShould()
        {
            castPointToken = new CastPointToken(castingType);
        }

        [Fact]
        public void ContainCastingType()
        {
            // Then
            Assert.Equal(CastingType.Air, castPointToken.CastingType);
        }

        [Theory]
        [InlineData(CastingType.Conventional, "Conventional ⚔")]
        [InlineData(CastingType.Life, "Life ❤")]
        [InlineData(CastingType.Air, "Air 🜁")]
        [InlineData(CastingType.Water, "Water 🜄")]
        [InlineData(CastingType.Earth, "Earth 🜃")]
        [InlineData(CastingType.Fire, "Fire 🜂")]
        public void ContainName(CastingType castingType, string name)
        {
            // Given
            ICastPointToken castPointToken = new CastPointToken(castingType);

            // Then
            Assert.NotNull(castPointToken.Name);
            Assert.Equal(name, castPointToken.Name.GenericName);
        }

        [Fact]
        public void ContainCastingPoints()
        {
            // Then
            Assert.Equal(10, castPointToken.CastingPoints);
        }

        [Theory]
        [InlineData(2, 8)]
        [InlineData(10, 0)]
        [InlineData(11, 0)]
        public void CostCastingToken(byte castingCost, byte remainingCastingPoints)
        {
            // When
            castPointToken.CostCastingToken(castingCost);

            // Then
            Assert.Equal(remainingCastingPoints, castPointToken.CastingPoints);
        }
    }
}