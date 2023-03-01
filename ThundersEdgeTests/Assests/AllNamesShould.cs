using ThundersEdge.Assests;
using ThundersEdge.Assests.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Assests
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