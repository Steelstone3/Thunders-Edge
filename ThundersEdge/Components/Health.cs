using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components
{
    public class Health : IHealth
    {
        public Health(byte maximumHealth, byte currentHealth)
        {
            MaximumHealth = maximumHealth;
            CurrentHealth = currentHealth;
        }

        public byte MaximumHealth { get; }
        public byte CurrentHealth { get; }
    }
}