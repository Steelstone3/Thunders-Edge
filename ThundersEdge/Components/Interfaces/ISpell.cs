using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Components.Interfaces
{
    public interface ISpell
    {
        void CastSpell(ICard defendingCard);
    }
}