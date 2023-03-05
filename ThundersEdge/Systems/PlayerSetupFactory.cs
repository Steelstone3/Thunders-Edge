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

        public PlayerSetupFactory(IPresenter presenter, IDeckFactory deckFactory)
        {
            this.presenter = presenter;
            this.deckFactory = deckFactory;
        }

        public IPlayer Create() => new Player(presenter.CharacterPresenter.AskPlayerName(), deckFactory.Create());
    }
}