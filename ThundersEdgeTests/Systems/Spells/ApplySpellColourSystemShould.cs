using Moq;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class ApplySpellColourSystemShould
    {
        const string SPELL_NAME = "Spark";

        [Theory]
        [InlineData(CastingType.Conventional, $"[lightslategrey]{SPELL_NAME}[/]")]
        [InlineData(CastingType.Life, $"[red]{SPELL_NAME}[/]")]
        [InlineData(CastingType.Air, $"[grey84]{SPELL_NAME}[/]")]
        [InlineData(CastingType.Water, $"[skyblue1]{SPELL_NAME}[/]")]
        [InlineData(CastingType.Earth, $"[rosybrown]{SPELL_NAME}[/]")]
        [InlineData(CastingType.Fire, $"[darkorange]{SPELL_NAME}[/]")]
        public void ApplySpellColour(CastingType castingType, string expectedColour)
        {
            // Given
            Mock<IName> name = new();
            name.Setup(n => n.GenericName).Returns(SPELL_NAME);
            IApplySpellColourSystem applySpellColour = new ApplySpellColourSystem();

            // When
            string colour = applySpellColour.ApplySpellColour(castingType, name.Object);

            // Then
            Assert.Equal(expectedColour, colour);
        }
    }
}