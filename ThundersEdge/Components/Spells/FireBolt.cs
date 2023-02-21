using System.Collections.Generic;
using System.Linq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Components.Spells
{
    public class FireBolt : ISpell
    {
        private const int DAMAGE = 25;
        private const byte CASTING_COST = 2;

        public IName Name => new Name("Fire Bolt 🜂");
        public CastingType CastElement => CastingType.Fire;
        public byte CastingCost => CASTING_COST;

        public void CastSpell(IEnumerable<ICastPointToken> pointsTokens, ICard defendingCard)
        {
            ICastPointToken pointsToken = pointsTokens.SingleOrDefault(pt => pt.CastingType == CastElement);

            if (pointsToken.CastingPoints >= CASTING_COST)
            {
                pointsToken.CostCastingToken(CASTING_COST);
                defendingCard.TakeDamage(DAMAGE);
            }
        }
    }
}