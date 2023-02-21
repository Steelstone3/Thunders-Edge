using System.Collections.Generic;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Components.Interfaces
{
    public interface ISpell
    {
        IName Name { get; }
        CastingType CastElement { get; }
        byte CastingCost { get; }
        byte Damage { get; }

        void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, IEnumerable<ICastPointToken> castPointTokens, ICard defendingCard);
    }
}