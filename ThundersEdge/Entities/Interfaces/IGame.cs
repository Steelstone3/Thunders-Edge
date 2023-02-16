using System.Collections.Generic;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IGame
    {
        IEnumerable<IPlayer> Players { get; }
    }
}