using System.Collections.Generic;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
{
    public class Game : IGame
    {
        public Game(IEnumerable<IPlayer> players)
        {
            Players = players;
        }

        public IEnumerable<IPlayer> Players { get; }
    }
}