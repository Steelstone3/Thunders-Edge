using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Services
{
    public class GameService : IGameService
    {
        private readonly IGameSetupFactory gameSetupFactory;
        private readonly ICombatSystem spellCastingSystem;

        public GameService(IGameSetupFactory gameSetupFactory, ICombatSystem spellCastingSystem)
        {
            this.gameSetupFactory = gameSetupFactory;
            this.spellCastingSystem = spellCastingSystem;
        }

        public void Run()
        {
            IGame game = gameSetupFactory.Create();
            spellCastingSystem.Start(game);
        }
    }
}