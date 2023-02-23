using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.SpellGroups
{
    public class SpellGroup : ISpellGroup
    {
        public SpellGroup(IEnumerable<ISpell> spells)
        {
            Spells = spells;
        }

        public IEnumerable<ISpell> Spells { get; }
    }
}