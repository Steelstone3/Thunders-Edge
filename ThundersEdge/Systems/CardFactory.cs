using ThundersEdge.Components.Character;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class CardFactory : ICardFactory
    {
        private readonly IPresenter presenter;
        private readonly ICharacterNameFactory characterNameFactory;
        private readonly ISpellGroupFactory spellGroupFactory;

        public CardFactory(IPresenter presenter, ICharacterNameFactory characterNameFactory, ISpellGroupFactory spellGroupFactory)
        {
            this.presenter = presenter;
            this.characterNameFactory = characterNameFactory;
            this.spellGroupFactory = spellGroupFactory;
        }

        public ICard Create()
        {
            return new Card(presenter, characterNameFactory.Create(), new Health(100, 100), spellGroupFactory.Create());
        }
    }
}