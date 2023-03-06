using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Components.Character
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

        [Theory]
        [InlineData(25, 75)]
        [InlineData(50, 50)]
        [InlineData(100, 0)]
        [InlineData(101, 0)]
        public void TakeDamage(byte damage, byte currentHealth)
        {
            // When
            health.TakeDamage(damage);

            // Then
            Assert.Equal(currentHealth, health.CurrentHealth);
            Assert.Equal(100, health.MaximumHealth);
        }
    }
}