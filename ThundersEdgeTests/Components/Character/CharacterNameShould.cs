using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Character
{
    public class CharacterNameShould
    {
        private const string FIRST_NAME = "First Name";
        private const string SURNAME = "Surname";
        private readonly ICharacterName name;

        public CharacterNameShould()
        {
            name = new CharacterName(FIRST_NAME, SURNAME);
        }

        [Fact]
        public void ContainsFirstName()
        {
            // Then
            Assert.Equal(FIRST_NAME, name.FirstName);
        }

        [Fact]
        public void ContainsSurname()
        {
            // Then
            Assert.Equal(SURNAME, name.Surname);
        }
    }
}