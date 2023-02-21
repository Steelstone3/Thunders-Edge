namespace ThundersEdge.Components.Interfaces
{
    public interface IHealth
    {
        byte MaximumHealth { get; }
        byte CurrentHealth { get; }
        void TakeDamage(byte damage);
    }
}