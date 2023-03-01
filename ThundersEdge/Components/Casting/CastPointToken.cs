using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.Casting
{
    public class CastPointToken : ICastPointToken
    {
        public CastPointToken(CastingType castingType)
        {
            CastingType = castingType;
            Name = AssignName();
        }

        public byte CastingPoints { get; private set; } = 10;
        public CastingType CastingType { get; }
        public IName Name { get; }

        public void CostCastingToken(byte castingCost)
        {
            CastingPoints = castingCost <= CastingPoints ? (byte)(CastingPoints - castingCost) : (byte)0;
            // TODO Create a deck presenter that shows the current state of the casting points as well as the casting cost
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