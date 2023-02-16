using System;
using System.Linq;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class RandomCharacterNameSystem : IRandomCharacterNameSystem
    {
        private readonly INames names = new Names();

        public string RandomFirstName() => names.FirstNames.ToList().OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
        public string RandomSurname() => names.Surnames.ToList().OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
    }
}