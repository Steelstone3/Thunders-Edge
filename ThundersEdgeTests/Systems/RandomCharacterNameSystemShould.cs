using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class RandomCharacterNameSystemShould
    {
        private readonly INames names = new Names();
        private readonly IRandomCharacterNameSystem randomCharacterNameSystem;

        public RandomCharacterNameSystemShould()
        {
            randomCharacterNameSystem = new RandomCharacterNameSystem();
        }

        [Fact]
        public void CreateRandomFirstName()
        {
            // Given
            IEnumerable<string> firstNames = names.FirstNames;

            // When
            string firstName = randomCharacterNameSystem.RandomFirstName();

            // Then
            Assert.Contains(firstName, firstNames);
        }

        [Fact]
        public void CreateRandomSurname()
        {
            // Given
            IEnumerable<string> surnames = names.Surnames;

            // When
            string surname = randomCharacterNameSystem.RandomSurname();

            // Then
            Assert.Contains(surname, surnames);
        }
    }
}