namespace ThundersEdge.Components.Interfaces
{
    public interface ICard
    {
        ICharacterName Name { get; }
        IHealth Health { get; }
        ISpellGroup SpellGroup { get; }
    }
}