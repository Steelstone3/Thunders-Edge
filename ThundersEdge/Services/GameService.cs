using System.Linq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Services
{
    public class GameService : IGameService
    {
        private readonly IGameSetupFactory gameSetupFactory;
        private readonly ISpellCastingSystem spellCastingSystem;

        public GameService(IGameSetupFactory gameSetupFactory, ISpellCastingSystem spellCastingSystem)
        {
            this.gameSetupFactory = gameSetupFactory;
            this.spellCastingSystem = spellCastingSystem;
        }

        public void Run()
        {
            IGame game = gameSetupFactory.Create();
            spellCastingSystem.CastSpell(game.Players.ToArray()[0], game.Players.ToArray()[1]);
            spellCastingSystem.CastSpell(game.Players.ToArray()[1], game.Players.ToArray()[0]);
        }
    }
}