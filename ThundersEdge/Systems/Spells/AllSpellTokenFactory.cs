using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
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