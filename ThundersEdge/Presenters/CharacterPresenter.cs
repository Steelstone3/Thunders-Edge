using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters.Interfaces;

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