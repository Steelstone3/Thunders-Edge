using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface ICombatSystem
    {
        void DetermineVictor(IGame game);
        void Start(IGame game);
    }
}