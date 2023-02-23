using System.Collections.Generic;

namespace ThundersEdge.Components.Interfaces
{
    public interface IAllNames
    {
        IEnumerable<string> FirstNames { get; }
        IEnumerable<string> Surnames { get; }
    }
}