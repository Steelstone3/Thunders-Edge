using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Assests.Interfaces
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
        bool HasCastingPoints();
    }
}