using Moq;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
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

        [Fact(Skip = "Later")]
        public void CostCastingToken()
        {
            // Given

            // When

            // Then
        }
    }
}