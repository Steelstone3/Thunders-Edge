using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IPlayer
    {
        public IDeck Deck { get; }
        public IAllCastPointTokens PointsTokens { get; }
        IName Name { get; }
    }
}