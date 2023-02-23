using ThundersEdge.Components;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Character
{
    public class AllNamesShould
    {
        private readonly IAllNames allNames;

        public AllNamesShould()
        {
            allNames = new AllNames();
        }

        [Fact]
        public void ContainsListOfFirstNames()
        {
            // Then
            Assert.NotEmpty(allNames.FirstNames);
        }

        [Fact]
        public void ContainsListOfSurname()
        {
            // Then
            Assert.NotEmpty(allNames.Surnames);
        }
    }
}