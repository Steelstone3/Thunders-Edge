using System.Collections.Generic;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Components.SpellGroups.Water;
using ThundersEdgeTests.Components.SpellGroups.Fire;

namespace ThundersEdge.Assests
{
    public class AllSpellGroups : IAllSpellGroups
    {
        public IEnumerable<ISpellGroup> SpellGroups { get; } = new List<ISpellGroup>()
        {
            new WaterOffensiveSpellGroup(),
            new FireOffensiveSpellGroup(),
        };
    }
}