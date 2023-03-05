using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class DamagingSpellCastSystem : IDamagingSpellCastSystem
    {
        private readonly IPresenter presenter;

        public DamagingSpellCastSystem(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void CastSpell(ISpell spell, ICard defendingCard)
        {
            if (spell.RemainingCastingPoints >= spell.CastingCost)
            {
                spell.CostCastingPoints(presenter);
                defendingCard.TakeDamage(spell.Damage);
            }
        }
    }
}