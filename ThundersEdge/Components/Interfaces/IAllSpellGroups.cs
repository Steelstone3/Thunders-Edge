using System.Collections.Generic;

namespace ThundersEdge.Components.Interfaces
{
    public interface IAllSpellGroups
    {
        IEnumerable<ISpellGroup> SpellGroups { get; }
    }
}