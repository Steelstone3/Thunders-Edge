using System.Collections.Generic;
using ThundersEdge.Entities;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class GameSetupFactory : IGameSetupFactory
    {
        private readonly IPlayerSetupFactory playerSetupFactory;

        public GameSetupFactory(IPlayerSetupFactory playerSetupFactory)
        {
            this.playerSetupFactory = playerSetupFactory;
        }

        public IGame Create()
        {
            List<IPlayer> players = new()
            {
                playerSetupFactory.Create(),
                playerSetupFactory.Create()
            };

            return new Game(players);
        }
    }
}