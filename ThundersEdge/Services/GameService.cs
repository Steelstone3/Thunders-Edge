using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Services
{
    public class GameService : IGameService
    {
        private readonly IGameSetupFactory gameSetupFactory;
        private readonly ICombatSystem combatSystem;

        public GameService(IGameSetupFactory gameSetupFactory, ICombatSystem combatSystem)
        {
            this.gameSetupFactory = gameSetupFactory;
            this.combatSystem = combatSystem;
        }

        public void Run()
        {
            IGame game = gameSetupFactory.Create();
            combatSystem.Start(game);
            combatSystem.DetermineVictor(game);
        }
    }
}