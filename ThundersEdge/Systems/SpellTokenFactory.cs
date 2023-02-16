using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class SpellTokenFactory : ISpellTokenFactory
    {
        public IEnumerable<ICastPointToken> Create()
        {
            return new List<ICastPointToken>() {
                new CastPointToken(new Name("Conventional ⚔"), CastingType.Conventional),
                new CastPointToken(new Name("Life ❤"), CastingType.Life),
                new CastPointToken(new Name("Air 🜁"), CastingType.Air),
                new CastPointToken(new Name("Water 🜄"), CastingType.Water),
                new CastPointToken(new Name("Earth 🜃"), CastingType.Earth),
                new CastPointToken(new Name("Fire 🜂"), CastingType.Fire),
            };
        }
    }
}