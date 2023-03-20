using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
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
            Assert.Equivalent(new Name("Conventional ⚔"), castingTypeName.Convensional);
            Assert.Equivalent(new Name("Life ❤"), castingTypeName.Life);
            Assert.Equivalent(new Name("Air 🜁"), castingTypeName.Air);
            Assert.Equivalent(new Name("Water 🜄"), castingTypeName.Water);
            Assert.Equivalent(new Name("Earth 🜃"), castingTypeName.Earth);
            Assert.Equivalent(new Name("Fire 🜂"), castingTypeName.Fire);
        }

        [Theory]
        [InlineData(CastingType.Conventional, "Conventional ⚔")]
        [InlineData(CastingType.Life, "Life ❤")]
        [InlineData(CastingType.Air, "Air 🜁")]
        [InlineData(CastingType.Water, "Water 🜄")]
        [InlineData(CastingType.Earth, "Earth 🜃")]
        [InlineData(CastingType.Fire, "Fire 🜂")]
        public void GetNameBasedOnSpellCastingType(CastingType castingType, string expectedName)
        {
            // When
            IName name = castingTypeName.GetCastingTypeName(castingType);

            // Then
            Assert.Equivalent(new Name(expectedName), name);
        }
    }
}