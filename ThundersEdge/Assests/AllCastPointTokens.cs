using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Assests
{
    public class AllCastPointTokens : IAllCastPointTokens
    {
        public AllCastPointTokens(IPresenter presenter)
        {
            ConventionalCastPointToken = new CastPointToken(presenter, CastingType.Conventional);
            LifeCastPointToken = new CastPointToken(presenter, CastingType.Life);
            AirCastPointToken = new CastPointToken(presenter, CastingType.Air);
            WaterCastPointToken = new CastPointToken(presenter, CastingType.Water);
            EarthCastPointToken = new CastPointToken(presenter, CastingType.Earth);
            FireCastPointToken = new CastPointToken(presenter, CastingType.Fire);
        }

        public ICastPointToken ConventionalCastPointToken
        {
            get;
        }

        public ICastPointToken LifeCastPointToken
        {
            get;
        }

        public ICastPointToken AirCastPointToken
        {
            get;
        }

        public ICastPointToken WaterCastPointToken
        {
            get;
        }

        public ICastPointToken EarthCastPointToken
        {
            get;
        }

        public ICastPointToken FireCastPointToken
        {
            get;
        }

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

        public bool HasCastingPoints()
        {
            return ConventionalCastPointToken.CastingPoints != 0 && LifeCastPointToken.CastingPoints != 0 && AirCastPointToken.CastingPoints != 0 && WaterCastPointToken.CastingPoints != 0 && EarthCastPointToken.CastingPoints != 0 && FireCastPointToken.CastingPoints != 0;
        }
    }
}