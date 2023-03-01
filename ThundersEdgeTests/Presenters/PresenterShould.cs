using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class PresenterShould
    {
        private readonly IPresenter presenter = new Presenter();

        [Fact]
        public void ContainsDeckPresenter()
        {
            // Then
            Assert.NotNull(presenter.DeckPresenter);
        }

        [Fact]
        public void ContainsSpellCastingPresenter()
        {
            // Then
            Assert.NotNull(presenter.SpellCastingPresenter);
        }

        [Fact]
        public void ContainsCharacterPresenter()
        {
            // Then
            Assert.NotNull(presenter.CharacterPresenter);
        }
    }
}