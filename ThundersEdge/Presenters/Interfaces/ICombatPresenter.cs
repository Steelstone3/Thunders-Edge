using System;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface ICombatPresenter
    {
        void PrintWinningDeck(IName winningPlayerName);
        void PrintDraw();
    }
}