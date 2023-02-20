using BubblesDivePlanner.Presenters;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Presenters;
using Xunit;

namespace ThundersEdgeTests.Presenters
{
    public class CharacterPresenterShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly ICharacterPresenter characterPresenter;

        public CharacterPresenterShould()
        {
            characterPresenter = new CharacterPresenter(presenter.Object);
        }

        [Fact]
        public void AskPlayerName()
        {
            // Given
            presenter.Setup(p => p.GetString("Enter player name:")).Returns("Bob");

            // When
            IName name = characterPresenter.AskCharacterName();

            // Then
            presenter.VerifyAll();
            Assert.NotNull(name);
        }
    }
}