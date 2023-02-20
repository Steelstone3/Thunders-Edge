using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface ISpellCastingSystem
    {
        void CastSpell(IPlayer attackingPlayer, IPlayer defendingPlayer);
    }
}