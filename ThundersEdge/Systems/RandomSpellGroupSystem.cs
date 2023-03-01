using System;
using System.Linq;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class RandomSpellGroupSystem : IRandomSpellGroupSystem
    {
        private readonly IAllSpellGroups allSpellGroups;

        public RandomSpellGroupSystem(IAllSpellGroups allSpellGroups)
        {
            this.allSpellGroups = allSpellGroups;
        }

        public ISpellGroup RandomSpellGroup()
        {
            return allSpellGroups.SpellGroups.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
        }
    }
}