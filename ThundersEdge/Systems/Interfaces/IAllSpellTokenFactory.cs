using ThundersEdge.Assests.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface IAllSpellTokenFactory
    {
        IAllCastPointTokens Create();
    }
}