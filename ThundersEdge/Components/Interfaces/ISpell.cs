using System.Collections.Generic;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Components.Interfaces
{
    public interface ISpell
    {
        IName Name { get; }
        CastingType CastElement { get; }
        byte CastingCost { get; }

        void CastSpell(IEnumerable<ICastPointToken> pointsTokens, ICard defendingCard);
    }
}