using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class PlayerSetupFactory : IPlayerSetupFactory
    {
        private readonly IDeckFactory deckFactory;
        private readonly ISpellTokenFactory spellTokenFactory;

        public PlayerSetupFactory(IDeckFactory deckFactory, ISpellTokenFactory spellTokenFactory)
        {
            this.deckFactory = deckFactory;
            this.spellTokenFactory = spellTokenFactory;
        }

        public IPlayer Create() => new Player(deckFactory.Create(), spellTokenFactory.Create());
    }
}