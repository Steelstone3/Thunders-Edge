using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Entities.Interfaces
{
    public interface ICard
    {
        ICharacterName Name { get; }
        IHealth Health { get; }
        ISpellGroup SpellGroup { get; }
        void TakeDamage(byte damage);
        bool IsCardStillInPlay();
        string GetSummary();
    }
}