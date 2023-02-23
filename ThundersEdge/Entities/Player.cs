using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
{
    public class Player : IPlayer
    {
        public Player(IName name, IDeck deck, IAllCastPointTokens pointsDeck)
        {
            Name = name;
            PointsTokens = pointsDeck;
            Deck = deck;
        }

        public IDeck Deck { get; }
        public IAllCastPointTokens PointsTokens { get; }
        public IName Name { get; }
    }
}