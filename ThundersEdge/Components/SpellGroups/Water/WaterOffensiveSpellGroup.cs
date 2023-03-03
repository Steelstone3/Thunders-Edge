using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.Spells.Conventional;
using ThundersEdge.Components.Spells.Water;
using ThundersEdgeTests.Components.Spells.Water;

namespace ThundersEdge.Components.SpellGroups.Water
{
    public class WaterOffensiveSpellGroup : ISpellGroup
    {
        public IEnumerable<ISpell> Spells { get; } = new List<ISpell>()
        {
            new Splash(),
            new TidalWave(),
            new Slash(),
        };
    }
}