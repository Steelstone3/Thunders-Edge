using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
{
    public class Player : IPlayer
    {
        public Player(IName name, IDeck deck, IEnumerable<ICastPointToken> pointsDeck)
        {
            Name = name;
            PointsTokens = pointsDeck;
            Deck = deck;
        }

        public IDeck Deck { get; }
        public IEnumerable<ICastPointToken> PointsTokens { get; }
        public IName Name { get; }
    }
}