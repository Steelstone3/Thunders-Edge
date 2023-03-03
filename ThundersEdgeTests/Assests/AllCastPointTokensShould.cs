using Castle.Components.DictionaryAdapter;
using Moq;
using ThundersEdge.Assests;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Assests
{
    public class AllCastPointTokensShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly IAllCastPointTokens allCastPointTokens;

        public AllCastPointTokensShould()
        {
            allCastPointTokens = new AllCastPointTokens(presenter.Object);
        }

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

        [Fact]
        public void CheckHasCastingPoints()
        {
            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.True(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPointsInOneCastingTypeConventional()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.ConventionalCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPointsInOneCastingTypeLife()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.LifeCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPointsInOneCastingTypeAir()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.AirCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPointsInOneCastingTypeWater()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.WaterCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPointsInOneCastingTypeEarth()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.EarthCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPointsInOneCastingTypeFire()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.FireCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }

        [Fact]
        public void CheckHasNoCastingPoints()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, 0));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);
            allCastPointTokens.ConventionalCastPointToken.CostCastingToken(byte.MaxValue);
            allCastPointTokens.LifeCastPointToken.CostCastingToken(byte.MaxValue);
            allCastPointTokens.AirCastPointToken.CostCastingToken(byte.MaxValue);
            allCastPointTokens.WaterCastPointToken.CostCastingToken(byte.MaxValue);
            allCastPointTokens.EarthCastPointToken.CostCastingToken(byte.MaxValue);
            allCastPointTokens.FireCastPointToken.CostCastingToken(byte.MaxValue);

            // When
            bool hasCastingPoints = allCastPointTokens.HasCastingPoints();

            // Then
            Assert.False(hasCastingPoints);
        }
    }
}