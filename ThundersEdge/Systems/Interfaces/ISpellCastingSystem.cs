using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface ISpellCastingSystem
    {
        bool CastSpell(IPlayer attackingPlayer, IPlayer defendingPlayer);
    }
}