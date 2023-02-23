using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.Casting
{
    public class CastPointToken : ICastPointToken
    {
        public CastPointToken(IName name, CastingType castingType)
        {
            Name = name;
            CastingType = castingType;
        }

        public byte CastingPoints { get; private set; } = 10;
        public CastingType CastingType { get; }
        public IName Name { get; }

        public void CostCastingToken(byte castingCost)
        {
            CastingPoints = castingCost <= CastingPoints ? (byte)(CastingPoints - castingCost) : (byte)0;
        }
    }
}