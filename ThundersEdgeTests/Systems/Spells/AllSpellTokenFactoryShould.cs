using Moq;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;
using Xunit;

namespace ThundersEdgeTests.Systems.Spells
{
    public class AllSpellTokenFactoryShould
    {
        private readonly IAllSpellTokenFactory allSpellTokenFactory;

        public AllSpellTokenFactoryShould()
        {
            Mock<IPresenter> presenter = new();
            allSpellTokenFactory = new AllSpellTokenFactory(presenter.Object);
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