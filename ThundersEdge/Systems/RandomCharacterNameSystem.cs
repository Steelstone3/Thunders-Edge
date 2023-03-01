using System;
using System.Linq;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Character;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class RandomCharacterNameSystem : IRandomCharacterNameSystem
    {
        private readonly IAllNames allNames;

        public RandomCharacterNameSystem(IAllNames allNames)
        {
            this.allNames = allNames;
        }

        public string RandomFirstName() => allNames.FirstNames.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
        public string RandomSurname() => allNames.Surnames.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
    }
}