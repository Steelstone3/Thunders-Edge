using System.Collections.Generic;

namespace ThundersEdge.Components.Interfaces
{
    public interface ISpellGroup
    {
        IEnumerable<ISpell> Spells { get; }
    }
}