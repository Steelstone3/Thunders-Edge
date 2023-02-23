using ThundersEdge.Components.Casting;

namespace ThundersEdge.Components.Interfaces
{
    public interface ICastPointToken
    {
        byte CastingPoints { get; }
        CastingType CastingType { get; }
        IName Name { get; }
        void CostCastingToken(byte castingCost);
    }
}