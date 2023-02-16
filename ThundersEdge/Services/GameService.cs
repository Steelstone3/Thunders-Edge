using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Services
{
    public class GameService : IGameService
    {
        private readonly IGameSetupFactory gameSetupFactory;

        public GameService(IGameSetupFactory gameSetupFactory)
        {
            this.gameSetupFactory = gameSetupFactory;
        }

        public void Run()
        {
            IGame game = gameSetupFactory.Create();
        }
    }
}