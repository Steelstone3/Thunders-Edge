using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class SpellTokenFactory : ISpellTokenFactory
    {
        private readonly ICastingTypeName castingTypeName = new CastingTypeName();

        public IEnumerable<ICastPointToken> Create()
        {
            return new List<ICastPointToken>() {
                new CastPointToken(new Name(castingTypeName.Convensional), CastingType.Conventional),
                new CastPointToken(new Name(castingTypeName.Life), CastingType.Life),
                new CastPointToken(new Name(castingTypeName.Air), CastingType.Air),
                new CastPointToken(new Name(castingTypeName.Water), CastingType.Water),
                new CastPointToken(new Name(castingTypeName.Earth), CastingType.Earth),
                new CastPointToken(new Name(castingTypeName.Fire), CastingType.Fire),
            };
        }
    }
}