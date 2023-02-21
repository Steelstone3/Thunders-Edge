using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class SpellTokenFactoryShould
    {
        private readonly ISpellTokenFactory spellTokenFactory;

        public SpellTokenFactoryShould()
        {
            spellTokenFactory = new SpellTokenFactory();
        }

        [Fact]
        public void Create()
        {
            // When
            IEnumerable<ICastPointToken> spellTokens = spellTokenFactory.Create();

            // Then
            Assert.NotEmpty(spellTokens);
        }
    }
}