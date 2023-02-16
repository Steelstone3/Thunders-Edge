using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class CharacterNameFactoryShould
    {
        private readonly Mock<IRandomCharacterNameSystem> randomCharacterNameSystem = new();
        private readonly ICharacterNameFactory characterNameFactory;

        public CharacterNameFactoryShould()
        {
            characterNameFactory = new CharacterNameFactory(randomCharacterNameSystem.Object);
        }

        [Fact]
        public void Create()
        {
            // Given
            randomCharacterNameSystem.Setup(rns => rns.RandomFirstName());
            randomCharacterNameSystem.Setup(rns => rns.RandomSurname());

            // When
            ICharacterName characterName = characterNameFactory.Create();

            // Then
            randomCharacterNameSystem.VerifyAll();
            Assert.NotNull(characterName);
        }
    }
}