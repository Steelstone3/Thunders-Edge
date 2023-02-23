using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class SpellGroupFactory : ISpellGroupFactory
    {
        private readonly IRandomSpellGroupSystem randomSpellGroupSystem;

        public SpellGroupFactory(IRandomSpellGroupSystem randomSpellGroupSystem)
        {
            this.randomSpellGroupSystem = randomSpellGroupSystem;
        }

        public ISpellGroup Create() => randomSpellGroupSystem.RandomSpellGroup();
    }
}