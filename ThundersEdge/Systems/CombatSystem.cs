using System.Linq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class CombatSystem : ICombatSystem
    {
        private readonly ISpellCastingSystem spellCastingSystem;
        private readonly IPresenter presenter;

        public CombatSystem(IPresenter presenter, ISpellCastingSystem spellCastingSystem)
        {
            this.spellCastingSystem = spellCastingSystem;
            this.presenter = presenter;
        }

        public void Start( IGame game)
        {
            do
            {
                spellCastingSystem.CastSpell(game.Players.ToArray()[0], game.Players.ToArray()[1]);
                spellCastingSystem.CastSpell(game.Players.ToArray()[1], game.Players.ToArray()[0]);
            } while (game.Players.ToArray()[0].Deck.IsDeckStillInPlay(presenter, game.Players.ToArray()[1].Name) || game.Players.ToArray()[1].Deck.IsDeckStillInPlay(presenter, game.Players.ToArray()[0].Name));
        }
    }
}