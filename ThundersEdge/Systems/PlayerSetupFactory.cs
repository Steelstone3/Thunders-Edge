using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class PlayerSetupFactory : IPlayerSetupFactory
    {
        private readonly ICharacterPresenter characterPresenter;
        private readonly IDeckFactory deckFactory;
        private readonly ISpellTokenFactory spellTokenFactory;

        public PlayerSetupFactory(ICharacterPresenter characterPresenter, IDeckFactory deckFactory, ISpellTokenFactory spellTokenFactory)
        {
            this.characterPresenter = characterPresenter;
            this.deckFactory = deckFactory;
            this.spellTokenFactory = spellTokenFactory;
        }

        public IPlayer Create() => new Player(characterPresenter.AskCharacterName(), deckFactory.Create(), spellTokenFactory.Create());
    }
}