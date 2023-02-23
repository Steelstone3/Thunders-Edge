using ThundersEdge.Components.Character;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class CardFactory : ICardFactory
    {
        private readonly ICharacterNameFactory characterNameFactory;
        private readonly ISpellGroupFactory spellGroupFactory;

        public CardFactory(ICharacterNameFactory characterNameFactory, ISpellGroupFactory spellGroupFactory)
        {
            this.characterNameFactory = characterNameFactory;
            this.spellGroupFactory = spellGroupFactory;
        }

        public ICard Create()
        {
            return new Card(characterNameFactory.Create(), new Health(100, 100), spellGroupFactory.Create());
        }
    }
}