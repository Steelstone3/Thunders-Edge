using ThundersEdge.Components.Casting;

namespace ThundersEdge.Components.Interfaces
{
    public interface IAllCastPointTokens
    {
        ICastPointToken ConventionalCastPointToken { get; }
        ICastPointToken LifeCastPointToken { get; }
        ICastPointToken AirCastPointToken { get; }
        ICastPointToken WaterCastPointToken { get; }
        ICastPointToken EarthCastPointToken { get; }
        ICastPointToken FireCastPointToken { get; }
        ICastPointToken GetCastPointTokenOfType(CastingType castingType);
    }
}