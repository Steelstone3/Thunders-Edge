using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface IAllSpellTokenFactory
    {
        IAllCastPointTokens Create();
    }
}