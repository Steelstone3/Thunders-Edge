using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
{
    public class NameShould
    {
        private const string NAME = "Some name";
        private readonly IName name;

        public NameShould()
        {
            name = new Name(NAME);
        }

        [Fact]
        public void ContainsName()
        {
            // Then
            Assert.Equal(NAME, name.GenericName);
        }
    }
}