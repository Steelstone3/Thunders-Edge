using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IDeck
    {
        IEnumerable<ICard> Cards { get; }
        bool IsDeckStillInPlay(IPresenter presenter, IName name);
    }
}