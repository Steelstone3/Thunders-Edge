using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Entities.Interfaces
{
    public interface IPlayer
    {
        public IDeck Deck { get; }
        IName Name { get; }
    }
}