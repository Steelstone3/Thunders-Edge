using System.Collections.Generic;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IDeck
    {
        IEnumerable<ICard> Cards { get; }
    }
}