using ThundersEdge.Components.Character;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class CardFactory : ICardFactory
    {
        private readonly IDeckPresenter deckPresenter;
        private readonly ICharacterNameFactory characterNameFactory;
        private readonly ISpellGroupFactory spellGroupFactory;

        public CardFactory(IDeckPresenter deckPresenter, ICharacterNameFactory characterNameFactory, ISpellGroupFactory spellGroupFactory)
        {
            this.deckPresenter = deckPresenter;
            this.characterNameFactory = characterNameFactory;
            this.spellGroupFactory = spellGroupFactory;
        }

        public ICard Create()
        {
            return new Card(deckPresenter, characterNameFactory.Create(), new Health(100, 100), spellGroupFactory.Create());
        }
    }
}