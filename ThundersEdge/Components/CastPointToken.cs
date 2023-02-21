using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components
{
    public class CastPointToken : ICastPointToken
    {
        public CastPointToken(IName name, CastingType castingType)
        {
            Name = name;
            CastingType = castingType;
        }

        public byte CastingPoints { get; } = 10;
        public CastingType CastingType { get; }
        public IName Name { get; }

        public void CostCastingToken(byte castingCost)
        {
            throw new System.NotImplementedException();
        }
    }
}