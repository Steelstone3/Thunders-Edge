using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface IDeckPresenter
    {
        string PrintCardSummary(ICard card);
        void PrintCardTakingDamage(byte damage, ICharacterName characterName, IHealth health);
        void PrintRemainingCastingToken(IName name, byte remainingCastingPoints);
    }
}