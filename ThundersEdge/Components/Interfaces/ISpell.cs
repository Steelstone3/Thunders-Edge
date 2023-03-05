using System.Collections.Generic;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Components.Interfaces
{
    public interface ISpell
    {
        IName Name { get; }
        CastingType CastElement { get; }
        byte CastingCost { get; }
        byte RemainingCastingPoints { get; }
        byte Damage { get; }

        void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, ICard defendingCard);
        void CostCastingPoints(IPresenter presenter);
    }
}