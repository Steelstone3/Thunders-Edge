using BubblesDivePlanner.Presenters;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Presenters
{
    public class CharacterPresenter : ICharacterPresenter
    {
        private readonly IPresenter presenter;

        public CharacterPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public IName AskCharacterName() => new Name(presenter.GetString("Enter player name:"));
    }
}