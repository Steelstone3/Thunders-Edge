using System.Linq;
using ThundersEdge.Components.Interfaces;
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

        public void Start(IGame game)
        {
            bool isGameRunning = game.Players.ToArray()[0].Deck.IsDeckStillInPlay() || game.Players.ToArray()[1].Deck.IsDeckStillInPlay();

            do
            {
                spellCastingSystem.CastSpell(game.Players.ToArray()[0], game.Players.ToArray()[1]);
                spellCastingSystem.CastSpell(game.Players.ToArray()[1], game.Players.ToArray()[0]);
            } while (isGameRunning);
        }

        public void DetermineVictor(IGame game)
        {
            IName playerOneName = game.Players.ToArray()[0].Name;
            IName playerTwoName = game.Players.ToArray()[1].Name;
            bool playerOneDefeated = !game.Players.ToArray()[0].Deck.IsDeckStillInPlay();
            bool playerTwoDefeated = !game.Players.ToArray()[1].Deck.IsDeckStillInPlay();

            if (playerOneDefeated && playerTwoDefeated)
            {
                presenter.CombatPresenter.PrintDraw();
            }
            else if (playerOneDefeated)
            {
                presenter.CombatPresenter.PrintWinningDeck(playerTwoName);
            }
            else
            {
                presenter.CombatPresenter.PrintWinningDeck(playerOneName);
            }
        }
    }
}