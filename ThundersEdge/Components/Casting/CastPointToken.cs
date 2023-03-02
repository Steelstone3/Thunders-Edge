using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge.Components.Casting
{
    public class CastPointToken : ICastPointToken
    {
        private readonly IPresenter presenter;

        public CastPointToken(IPresenter presenter, CastingType castingType)
        {
            this.presenter = presenter;
            CastingType = castingType;
            Name = AssignName();
        }

        public byte CastingPoints { get; private set; } = 10;
        public CastingType CastingType { get; }
        public IName Name { get; }

        public void CostCastingToken(byte castingCost)
        {
            CastingPoints = castingCost <= CastingPoints ? (byte)(CastingPoints - castingCost) : (byte)0;
            presenter.DeckPresenter.PrintRemainingCastingToken(Name, CastingPoints);
        }

        private IName AssignName()
        {
            ICastingTypeName castingTypeName = new CastingTypeName();

            return CastingType switch
            {
                CastingType.Conventional => new ApplySpellColourSystem().ApplySpellColour(CastingType, castingTypeName.Convensional),
                CastingType.Life => new ApplySpellColourSystem().ApplySpellColour(CastingType, castingTypeName.Life),
                CastingType.Air => new ApplySpellColourSystem().ApplySpellColour(CastingType, castingTypeName.Air),
                CastingType.Water => new ApplySpellColourSystem().ApplySpellColour(CastingType, castingTypeName.Water),
                CastingType.Earth => new ApplySpellColourSystem().ApplySpellColour(CastingType, castingTypeName.Earth),
                CastingType.Fire => new ApplySpellColourSystem().ApplySpellColour(CastingType, castingTypeName.Fire),
                _ => null,
            };
        }
    }
}