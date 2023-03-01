using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class CardFactoryShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly Mock<ICharacterNameFactory> characterNameFactory = new();
        private readonly Mock<ISpellGroupFactory> spellGroupFactory = new();
        private readonly ICardFactory cardFactory;

        public CardFactoryShould()
        {
            cardFactory = new CardFactory(presenter.Object, characterNameFactory.Object, spellGroupFactory.Object);
        }

        [Fact]
        public void Create()
        {
            // Given
            characterNameFactory.Setup(cnf => cnf.Create());
            spellGroupFactory.Setup(sf => sf.Create());

            // When
            ICard card = cardFactory.Create();

            // Then
            characterNameFactory.VerifyAll();
            spellGroupFactory.VerifyAll();
            Assert.NotNull(card);
        }
    }
}