using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Presenters.Interfaces
{
    public interface IDeckPresenter
    {
        void PrintCardTakingDamage(byte damage, ICharacterName characterName, IHealth health);
        void PrintRemainingCastingToken(IName name, byte remainingCastingPoints);
        void PrintDeckDefeated(IName winningPlayerName);
    }
}