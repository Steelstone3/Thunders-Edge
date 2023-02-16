using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
{
    public class Player : IPlayer
    {
        public Player(IDeck deck, IEnumerable<ICastPointToken> pointsDeck)
        {
            Deck = deck;
            PointsTokens = pointsDeck;
        }

        public IDeck Deck { get; }
        public IEnumerable<ICastPointToken> PointsTokens { get; }
    }
}