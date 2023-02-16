using System.Collections.Generic;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface ISpellTokenFactory
    {
        IEnumerable<ICastPointToken> Create();
    }
}