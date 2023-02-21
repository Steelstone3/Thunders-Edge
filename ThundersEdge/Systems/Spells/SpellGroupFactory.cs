using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class SpellGroupFactory : ISpellGroupFactory
    {
        private const int SPELL_COUNT = 3;

        public SpellGroupFactory()
        {
        }

        public ISpellGroup Create()
        {
            return new SpellGroup(null);
        }
    }
}