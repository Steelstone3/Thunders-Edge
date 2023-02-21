using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components
{
    public class HealthShould
    {
        private readonly IHealth health;

        public HealthShould()
        {
            health = new Health(100, 100);
        }

        [Fact]
        public void ContainsMaximumHealthPoints()
        {
            // Then
            Assert.Equal(100, health.MaximumHealth);
        }

        [Fact]
        public void ContainsCurrentHealthPoints()
        {
            // Then
            Assert.Equal(100, health.CurrentHealth);
        }

        [Fact]
        public void TakeDamage()
        {
            // When
            health.TakeDamage(25);

            // Then
            Assert.Equal(75, health.CurrentHealth);
            Assert.Equal(100, health.MaximumHealth);
        }
    }
}