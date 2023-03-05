using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Entities
{
    public class Player : IPlayer
    {
        public Player(IName name, IDeck deck)
        {
            Name = name;
            Deck = deck;
        }

        public IDeck Deck { get; }
        public IName Name { get; }
    }
}