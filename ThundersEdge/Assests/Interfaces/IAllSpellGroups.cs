using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Assests.Interfaces
{
    public interface IAllSpellGroups
    {
        IEnumerable<ISpellGroup> SpellGroups { get; }
    }
}