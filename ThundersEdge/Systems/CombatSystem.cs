using System.Linq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class CombatSystem : ICombatSystem
    {
        private readonly ISpellCastingSystem spellCastingSystem;

        public CombatSystem(ISpellCastingSystem spellCastingSystem)
        {
            this.spellCastingSystem = spellCastingSystem;
        }

        public void Start(IGame game)
        {
            spellCastingSystem.CastSpell(game.Players.ToArray()[0], game.Players.ToArray()[1]);
            spellCastingSystem.CastSpell(game.Players.ToArray()[1], game.Players.ToArray()[0]);
        }
    }
}