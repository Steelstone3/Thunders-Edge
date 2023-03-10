using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.Character
{
    public class CharacterName : ICharacterName
    {
        public CharacterName(string firstName, string surname)
        {
            FirstName = firstName;
            Surname = surname;
        }

        public string FirstName { get; }
        public string Surname { get; }
    }
}