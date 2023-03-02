using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface IDamagingSpellCastSystem
    {
        void CastSpell(ISpell spell, IAllCastPointTokens castPointTokens, ICard defendingCard);
    }
}