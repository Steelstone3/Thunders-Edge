using Castle.Components.DictionaryAdapter;
using Moq;
using ThundersEdge;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class DeckFactoryShould
    {
        private readonly Mock<ICardFactory> cardFactory = new();
        private readonly IDeckFactory deckFactory;

        public DeckFactoryShould()
        {
            deckFactory = new DeckFactory(cardFactory.Object);
        }

        [Fact]
        public void Create()
        {
            // Given
            cardFactory.Setup(cf => cf.Create());

            // When
            IDeck deck = deckFactory.Create();

            // Then
            cardFactory.VerifyAll();
            Assert.NotNull(deck);
        }
    }
}