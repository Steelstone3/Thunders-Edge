using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.Spells.Conventional;
using ThundersEdge.Components.Spells.Fire;

namespace ThundersEdgeTests.Components.SpellGroups.Fire
{
    public class FireOffensiveSpellGroup : ISpellGroup
    {
        public IEnumerable<ISpell> Spells { get; } = new List<ISpell>()
        {
            new FireBolt(),
            new Slash(),
        };
    }
}