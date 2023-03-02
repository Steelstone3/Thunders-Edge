using Moq;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Casting
{
    public class CastPointTokenShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly CastingType castingType = CastingType.Air;
        private readonly ICastPointToken castPointToken;

        public CastPointTokenShould()
        {
            castPointToken = new CastPointToken(presenter.Object, castingType);
        }

        [Fact]
        public void ContainCastingType()
        {
            // Then
            Assert.Equal(CastingType.Air, castPointToken.CastingType);
        }

        [Theory]
        [InlineData(CastingType.Conventional, "[lightslategrey]Conventional ⚔[/]")]
        [InlineData(CastingType.Life, "[red]Life ❤[/]")]
        [InlineData(CastingType.Air, "[grey84]Air 🜁[/]")]
        [InlineData(CastingType.Water, "[skyblue1]Water 🜄[/]")]
        [InlineData(CastingType.Earth, "[rosybrown]Earth 🜃[/]")]
        [InlineData(CastingType.Fire, "[darkorange]Fire 🜂[/]")]
        public void ContainName(CastingType castingType, string castingName)
        {
            // Given
            IName name = new Name(castingName);

            // When
            ICastPointToken castPointToken = new CastPointToken(presenter.Object, castingType);

            // Then
            Assert.NotNull(castPointToken.Name);
            Assert.Equivalent(name, castPointToken.Name);
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
            // Given
            Mock<IName> name = new();
            Mock<IDeckPresenter> deckPresenter = new();
            deckPresenter.Setup(dp => dp.PrintRemainingCastingToken(name.Object, remainingCastingPoints));
            presenter.Setup(p => p.DeckPresenter).Returns(deckPresenter.Object);

            // When
            castPointToken.CostCastingToken(castingCost);

            // Then
            Assert.Equal(remainingCastingPoints, castPointToken.CastingPoints);
        }
    }
}