using System.Collections.Generic;
using System.Linq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class DamagingSpellCastSystem : IDamagingSpellCastSystem
    {
        public void CastSpell(ISpell spell, IEnumerable<ICastPointToken> castPointTokens, ICard defendingCard)
        {
           ICastPointToken pointsToken = castPointTokens.SingleOrDefault(pt => pt.CastingType == spell.CastElement);

            if (pointsToken.CastingPoints >= spell.CastingCost)
            {
                pointsToken.CostCastingToken(spell.CastingCost);
                defendingCard.TakeDamage(spell.Damage);
            }
        }
    }
}