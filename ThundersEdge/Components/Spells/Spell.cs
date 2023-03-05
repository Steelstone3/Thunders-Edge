using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Components.Spells
{
    public class Spell : ISpell
    {
        public IName Name { get; protected set; } = new Name("Default");
        public CastingType CastElement { get; protected set; } = CastingType.Conventional;
        public byte CastingCost { get; protected set; } = 1;
        public byte RemainingCastingPoints { get; protected set; } = 2;
        public byte Damage { get; protected set; } = 1;

        public void CastSpell(IDamagingSpellCastSystem damagingSpellCastSystem, ICard defendingCard)
        {
            damagingSpellCastSystem.CastSpell(this, defendingCard);
        }

        public void CostCastingPoints(IPresenter presenter)
        {
            RemainingCastingPoints = (byte)(RemainingCastingPoints != 0 ? RemainingCastingPoints - CastingCost : 0);
            presenter.DeckPresenter.PrintRemainingCastingToken(Name, RemainingCastingPoints);
        }
    }
}