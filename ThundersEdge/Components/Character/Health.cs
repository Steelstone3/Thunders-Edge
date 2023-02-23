using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components.Character
{
    public class Health : IHealth
    {
        public Health(byte maximumHealth, byte currentHealth)
        {
            MaximumHealth = maximumHealth;
            CurrentHealth = currentHealth;
        }

        public byte MaximumHealth { get; }
        public byte CurrentHealth { get; private set; }

        public void TakeDamage(byte damage)
        {
            CurrentHealth = (byte)(CurrentHealth - damage);
        }
    }
}