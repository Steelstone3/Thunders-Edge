using System.Collections.Generic;

namespace ThundersEdge.Components.Interfaces
{
    public interface IDeck
    {
        IEnumerable<ICard> Cards { get; }
    }
}