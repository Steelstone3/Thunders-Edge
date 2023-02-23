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
        private readonly IAllSpellTokenFactory spellTokenFactory;

        public PlayerSetupFactory(ICharacterPresenter characterPresenter, IDeckFactory deckFactory, IAllSpellTokenFactory spellTokenFactory)
        {
            this.characterPresenter = characterPresenter;
            this.deckFactory = deckFactory;
            this.spellTokenFactory = spellTokenFactory;
        }

        public IPlayer Create() => new Player(characterPresenter.AskCharacterName(), deckFactory.Create(), spellTokenFactory.Create());
    }
}