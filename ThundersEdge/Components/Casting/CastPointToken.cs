using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;

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
                CastingType.Conventional => new Name(castingTypeName.Convensional),
                CastingType.Life => new Name(castingTypeName.Life),
                CastingType.Air => new Name(castingTypeName.Air),
                CastingType.Water => new Name(castingTypeName.Water),
                CastingType.Earth => new Name(castingTypeName.Earth),
                CastingType.Fire => new Name(castingTypeName.Fire),
                _ => null,
            };
        }
    }
}