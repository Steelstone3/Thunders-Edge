using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Assests
{
    public class AllCastPointTokensShould
    {
        private readonly IAllCastPointTokens allCastPointTokens = new AllCastPointTokens();

        [Fact]
        public void ContainsConventionalCastPointToken()
        {
            // Then
            Assert.NotNull(allCastPointTokens.ConventionalCastPointToken);
            Assert.Equal(CastingType.Conventional, allCastPointTokens.ConventionalCastPointToken.CastingType);
        }

        [Fact]
        public void ContainsLifeCastPointToken()
        {
            // Then
            Assert.NotNull(allCastPointTokens.LifeCastPointToken);
            Assert.Equal(CastingType.Life, allCastPointTokens.LifeCastPointToken.CastingType);
        }

        [Fact]
        public void ContainsAirCastPointToken()
        {
            // Then
            Assert.NotNull(allCastPointTokens.AirCastPointToken);
            Assert.Equal(CastingType.Air, allCastPointTokens.AirCastPointToken.CastingType);
        }

        [Fact]
        public void ContainsWaterCastPointToken()
        {
            // Then
            Assert.NotNull(allCastPointTokens.WaterCastPointToken);
            Assert.Equal(CastingType.Water, allCastPointTokens.WaterCastPointToken.CastingType);
        }

        [Fact]
        public void ContainsEarthCastPointToken()
        {
            // Then
            Assert.NotNull(allCastPointTokens.EarthCastPointToken);
            Assert.Equal(CastingType.Earth, allCastPointTokens.EarthCastPointToken.CastingType);
        }

        [Fact]
        public void ContainsFireCastPointToken()
        {
            // Then
            Assert.NotNull(allCastPointTokens.FireCastPointToken);
            Assert.Equal(CastingType.Fire, allCastPointTokens.FireCastPointToken.CastingType);
        }

        [Fact]
        public void GetCastPointTokenOfTypeConventional()
        {
            // When
            ICastPointToken castPointToken = allCastPointTokens.GetCastPointTokenOfType(CastingType.Conventional);

            // Then
            Assert.Same(allCastPointTokens.ConventionalCastPointToken, castPointToken);
        }

        [Fact]
        public void GetCastPointTokenOfTypeLife()
        {
            // When
            ICastPointToken castPointToken = allCastPointTokens.GetCastPointTokenOfType(CastingType.Life);

            // Then
            Assert.Same(allCastPointTokens.LifeCastPointToken, castPointToken);
        }

        [Fact]
        public void GetCastPointTokenOfTypeAir()
        {
            // When
            ICastPointToken castPointToken = allCastPointTokens.GetCastPointTokenOfType(CastingType.Air);

            // Then
            Assert.Same(allCastPointTokens.AirCastPointToken, castPointToken);
        }

        [Fact]
        public void GetCastPointTokenOfTypeWater()
        {
            // When
            ICastPointToken castPointToken = allCastPointTokens.GetCastPointTokenOfType(CastingType.Water);

            // Then
            Assert.Same(allCastPointTokens.WaterCastPointToken, castPointToken);
        }

        [Fact]
        public void GetCastPointTokenOfTypeEarth()
        {
            // When
            ICastPointToken castPointToken = allCastPointTokens.GetCastPointTokenOfType(CastingType.Earth);

            // Then
            Assert.Same(allCastPointTokens.EarthCastPointToken, castPointToken);
        }

        [Fact]
        public void GetCastPointTokenOfTypeFire()
        {
            // When
            ICastPointToken castPointToken = allCastPointTokens.GetCastPointTokenOfType(CastingType.Fire);

            // Then
            Assert.Same(allCastPointTokens.FireCastPointToken, castPointToken);
        }
    }
}