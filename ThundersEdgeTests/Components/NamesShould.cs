using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
{
    public class NamesShould
    {
        private readonly INames names;

        public NamesShould()
        {
            names = new Names();
        }

        [Fact]
        public void ContainsListOfFirstNames()
        {
            // Then
            Assert.NotEmpty(names.FirstNames);
        }

        [Fact]
        public void ContainsListOfSurname()
        {
            // Then
            Assert.NotEmpty(names.Surnames);
        }
    }
}