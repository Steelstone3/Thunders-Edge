using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Casting
{
    public class CastingTypeNameShould
    {
        private readonly ICastingTypeName castingTypeName = new CastingTypeName();

        [Fact]
        public void ContainTypeNames()
        {
            // Then
            Assert.Equal("Conventional ⚔", castingTypeName.Convensional);
            Assert.Equal("Life ❤", castingTypeName.Life);
            Assert.Equal("Air 🜁", castingTypeName.Air);
            Assert.Equal("Water 🜄", castingTypeName.Water);
            Assert.Equal("Earth 🜃", castingTypeName.Earth);
            Assert.Equal("Fire 🜂", castingTypeName.Fire);
        }
    }
}