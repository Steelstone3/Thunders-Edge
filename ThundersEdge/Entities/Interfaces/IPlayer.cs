using System.Collections;
using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IPlayer
    {
        public IDeck Deck { get; }
        public IEnumerable<ICastPointToken> PointsTokens { get; }
        IName Name { get; }
    }
}