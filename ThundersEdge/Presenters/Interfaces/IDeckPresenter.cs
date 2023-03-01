using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface IDeckPresenter
    {
        void PrintCardTakingDamage(byte damage, ICharacterName characterName, IHealth health);
    }
}