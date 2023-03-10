using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;

namespace ThundersEdge.Presenters
{
    public class DeckPresenter : IDeckPresenter
    {
        private readonly IPresenter presenter;

        public DeckPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void PrintCardTakingDamage(byte damage, ICharacterName characterName, IHealth health)
        {
            presenter.Print($"{characterName.FirstName} {characterName.Surname} took [red]{damage}[/] damage [red]{health.CurrentHealth}[/]/[red]{health.MaximumHealth}[/]");
        }

        public void PrintRemainingCastingToken(IName name, byte remainingCastingPoints)
        {
            presenter.Print($"Casting Type: {name.GenericName}\nCasting Points Remaining: {remainingCastingPoints}");
        }
    }
}