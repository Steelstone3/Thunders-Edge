using Moq;
using ThundersEdge.Components;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Casting
{
    public class CastPointTokenShould
    {
        private readonly Mock<IName> name = new();
        private readonly CastingType castingType = CastingType.Air;
        private readonly ICastPointToken castPointToken;

        public CastPointTokenShould()
        {
            castPointToken = new CastPointToken(name.Object, castingType);
        }

        [Fact]
        public void ContainCastingType()
        {
            // Then
            Assert.Equal(CastingType.Air, castPointToken.CastingType);
        }

        [Fact]
        public void ContainName()
        {
            // Then
            Assert.NotNull(castPointToken.Name);
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