using System.Collections.Generic;

namespace ThundersEdge.Components.Interfaces
{
    public interface INames
    {
        IEnumerable<string> FirstNames { get; }
        IEnumerable<string> Surnames { get; }
    }
}