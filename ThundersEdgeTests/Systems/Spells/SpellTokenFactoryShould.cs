using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class SpellTokenFactoryShould
    {
        private readonly IAllSpellTokenFactory allSpellTokenFactory;

        public SpellTokenFactoryShould()
        {
            allSpellTokenFactory = new AllSpellTokenFactory();
        }

        [Fact]
        public void Create()
        {
            // When
            IAllCastPointTokens spellTokens = allSpellTokenFactory.Create();

            // Then
            Assert.NotNull(spellTokens);
        }
    }
}