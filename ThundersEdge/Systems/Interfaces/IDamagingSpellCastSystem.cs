using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface IDamagingSpellCastSystem
    {
        void CastSpell(ISpell spell, ICard defendingCard);
    }
}