using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class PlayerSetupFactory : IPlayerSetupFactory
    {
        private readonly IPresenter presenter;
        private readonly IDeckFactory deckFactory;
        private readonly IAllSpellTokenFactory spellTokenFactory;

        public PlayerSetupFactory(IPresenter presenter, IDeckFactory deckFactory, IAllSpellTokenFactory spellTokenFactory)
        {
            this.presenter = presenter;
            this.deckFactory = deckFactory;
            this.spellTokenFactory = spellTokenFactory;
        }

        public IPlayer Create() => new Player(presenter.CharacterPresenter.AskCharacterName(), deckFactory.Create(), spellTokenFactory.Create());
    }
}