using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Entities.Interfaces
{
    public interface ICard
    {
        ICharacterName Name { get; }
        // TODO AH Check if card is alive
        IHealth Health { get; }
        ISpellGroup SpellGroup { get; }
        void TakeDamage(byte damage);
        string GetSummary();
    }
}