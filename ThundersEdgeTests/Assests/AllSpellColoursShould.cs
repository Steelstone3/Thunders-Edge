using ThundersEdge.Assests;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using Xunit;

namespace ThundersEdgeTests.Assests
{
    public class AllSpellColoursShould
    {
        [Theory]
        [InlineData(CastingType.Conventional, "[lightslategrey]")]
        [InlineData(CastingType.Life, "[red]")]
        [InlineData(CastingType.Air, "[grey84]")]
        [InlineData(CastingType.Water, "[skyblue1]")]
        [InlineData(CastingType.Earth, "[rosybrown]")]
        [InlineData(CastingType.Fire, "[darkorange]")]
        public void GetSpellColour(CastingType castingType, string expectedColour)
        {
            // Given
            IAllSpellColours allSpellColours = new AllSpellColours();

            // When
            string colour = allSpellColours.GetSpellColour(castingType);

            // Then
            Assert.Equal(expectedColour, colour);
        }
    }
}