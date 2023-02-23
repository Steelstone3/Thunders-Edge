using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.Casting
{
    public class AllCastPointTokens : IAllCastPointTokens
    {
        public ICastPointToken ConventionalCastPointToken
        {
            get;
        } = new CastPointToken(CastingType.Conventional);

        public ICastPointToken LifeCastPointToken
        {
            get;
        } = new CastPointToken(CastingType.Life);

        public ICastPointToken AirCastPointToken
        {
            get;
        } = new CastPointToken(CastingType.Air);

        public ICastPointToken WaterCastPointToken
        {
            get;
        } = new CastPointToken(CastingType.Water);

        public ICastPointToken EarthCastPointToken
        {
            get;
        } = new CastPointToken(CastingType.Earth);

        public ICastPointToken FireCastPointToken
        {
            get;
        } = new CastPointToken(CastingType.Fire);

        public ICastPointToken GetCastPointTokenOfType(CastingType castingType)
        {
            return castingType switch
            {
                CastingType.Conventional => ConventionalCastPointToken,
                CastingType.Life => LifeCastPointToken,
                CastingType.Air => AirCastPointToken,
                CastingType.Water => WaterCastPointToken,
                CastingType.Earth => EarthCastPointToken,
                CastingType.Fire => FireCastPointToken,
                _ => null,
            };
        }
    }
}