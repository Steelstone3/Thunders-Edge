using System;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Presenters
{
    public class CombatPresenter : ICombatPresenter
    {
        private readonly IPresenter presenter;

        public CombatPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void PrintWinningDeck(IName winningPlayerName)
        {
            presenter.Print($"Game over! {winningPlayerName.GenericName} wins the match.");
        }

        public void PrintDraw()
        {
            presenter.Print("Game over! Draw.");
        }
    }
}