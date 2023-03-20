using ThundersEdge.Components.Casting;

namespace ThundersEdge.Components.Interfaces
{
    public interface ICastingTypeName
    {
        IName Life { get; }
        IName Convensional { get; }
        IName Air { get; }
        IName Water { get; }
        IName Earth { get; }
        IName Fire { get; }
        IName GetCastingTypeName(CastingType castingType);
    }
}