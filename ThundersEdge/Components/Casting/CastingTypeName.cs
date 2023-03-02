using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.Casting
{
    public class CastingTypeName : ICastingTypeName
    {
        public IName Convensional => new Name("Conventional ⚔");
        public IName Life => new Name("Life ❤");
        public IName Air => new Name("Air 🜁");
        public IName Water => new Name("Water 🜄");
        public IName Earth => new Name("Earth 🜃");
        public IName Fire => new Name("Fire 🜂");
    }
}