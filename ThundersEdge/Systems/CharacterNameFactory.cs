using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class CharacterNameFactory : ICharacterNameFactory
    {
        private readonly IRandomCharacterNameSystem randomCharacterNameSystem;

        public CharacterNameFactory(IRandomCharacterNameSystem randomCharacterNameSystem)
        {
            this.randomCharacterNameSystem = randomCharacterNameSystem;
        }

        public ICharacterName Create() => new CharacterName(randomCharacterNameSystem.RandomFirstName(), randomCharacterNameSystem.RandomSurname());
    }
}