using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
{
    public class CastingTypeNameShould
    {
        readonly ICastingTypeName castingTypeName = new CastingTypeName();

        [Fact]
        public void TestName()
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