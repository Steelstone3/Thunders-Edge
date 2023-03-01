using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class DamagingSpellCastSystem : IDamagingSpellCastSystem
    {
        public void CastSpell(ISpell spell, IAllCastPointTokens castPointTokens, ICard defendingCard)
        {
            ICastPointToken castPointToken = castPointTokens.GetCastPointTokenOfType(spell.CastElement);

            if (castPointToken.CastingPoints >= spell.CastingCost)
            {
                castPointToken.CostCastingToken(spell.CastingCost);
                defendingCard.TakeDamage(spell.Damage);
            }
        }
    }
}