using System.Collections.Generic;
using ThundersEdge.Assests;
using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class RandomCharacterNameSystemShould
    {
        private readonly IAllNames allNames = new AllNames();
        private readonly IRandomCharacterNameSystem randomCharacterNameSystem;

        public RandomCharacterNameSystemShould()
        {
            randomCharacterNameSystem = new RandomCharacterNameSystem(allNames);
        }

        [Fact]
        public void CreateRandomFirstName()
        {
            // Given
            IEnumerable<string> firstNames = allNames.FirstNames;

            // When
            string firstName = randomCharacterNameSystem.RandomFirstName();

            // Then
            Assert.Contains(firstName, firstNames);
        }

        [Fact]
        public void CreateRandomSurname()
        {
            // Given
            IEnumerable<string> surnames = allNames.Surnames;

            // When
            string surname = randomCharacterNameSystem.RandomSurname();

            // Then
            Assert.Contains(surname, surnames);
        }
    }
}