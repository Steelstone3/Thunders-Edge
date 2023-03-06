using System.Collections.Generic;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IDeck
    {
        // TODO AH Check the health (IsAlive on card in linq comparing each) of each card and if all are dead
        IEnumerable<ICard> Cards { get; }
        bool IsDeckStillInPlay();
    }
}