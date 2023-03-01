using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class AllSpellTokenFactory : IAllSpellTokenFactory
    {
        public IAllCastPointTokens Create()
        {
            return new AllCastPointTokens();
        }
    }
}