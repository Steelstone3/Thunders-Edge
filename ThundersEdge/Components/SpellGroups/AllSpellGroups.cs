using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;
using ThundersEdgeTests.Components.SpellGroups.Fire;

namespace ThundersEdge.Components.SpellGroups
{
    public class AllSpellGroups : IAllSpellGroups
    {
        public IEnumerable<ISpellGroup> SpellGroups { get; } = new List<ISpellGroup>()
        {
            new FireOffensiveSpellGroup()
        };
    }
}