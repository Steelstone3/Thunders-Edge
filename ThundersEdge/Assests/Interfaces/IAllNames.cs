using System.Collections.Generic;

namespace ThundersEdge.Assests.Interfaces
{
    public interface IAllNames
    {
        IEnumerable<string> FirstNames { get; }
        IEnumerable<string> Surnames { get; }
    }
}