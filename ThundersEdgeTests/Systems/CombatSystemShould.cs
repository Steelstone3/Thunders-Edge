using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class CombatSystemShould
    {
        private readonly Mock<IPresenter> presenter = new();
        private readonly Mock<IPlayer> player = new();
        private readonly Mock<IGame> game = new();
        private readonly Mock<ISpellCastingSystem> spellCastingSystem = new();
        private readonly ICombatSystem combatSystem;

        public CombatSystemShould()
        {
            combatSystem = new CombatSystem(presenter.Object, spellCastingSystem.Object);
        }

        [Fact]
        public void StartCombat()
        {
            // Given
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, player.Object });
            spellCastingSystem.Setup(scs => scs.CastSpell(player.Object, player.Object)).Returns(false);

            // When
            combatSystem.Start(game.Object);

            // Then
            spellCastingSystem.VerifyAll();
        }

        [Fact]
        public void DeterminePlayerOneDefeated()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeck> deck = new();
            deck.Setup(d => d.IsDeckStillInPlay()).Returns(false);
            player.Setup(p => p.Deck).Returns(deck.Object);
            player.Setup(p => p.Name).Returns(name.Object);
            Mock<IDeck> anotherDeck = new();
            anotherDeck.Setup(d => d.IsDeckStillInPlay()).Returns(true);
            Mock<IPlayer> anotherPlayer = new();
            anotherPlayer.Setup(p => p.Deck).Returns(anotherDeck.Object);
            anotherPlayer.Setup(p => p.Name).Returns(name.Object);
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, anotherPlayer.Object });
            Mock<ICombatPresenter> combatPresenter = new();
            combatPresenter.Setup(dp => dp.PrintWinningDeck(name.Object));
            presenter.Setup(p => p.CombatPresenter).Returns(combatPresenter.Object);

            // When
            combatSystem.DetermineVictor(game.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void DeterminePlayerTwoDefeated()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeck> deck = new();
            deck.Setup(d => d.IsDeckStillInPlay()).Returns(true);
            player.Setup(p => p.Deck).Returns(deck.Object);
            player.Setup(p => p.Name).Returns(name.Object);
            Mock<IDeck> anotherDeck = new();
            anotherDeck.Setup(d => d.IsDeckStillInPlay()).Returns(false);
            Mock<IPlayer> anotherPlayer = new();
            anotherPlayer.Setup(p => p.Deck).Returns(anotherDeck.Object);
            anotherPlayer.Setup(p => p.Name).Returns(name.Object);
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, anotherPlayer.Object });
            Mock<ICombatPresenter> combatPresenter = new();
            combatPresenter.Setup(dp => dp.PrintWinningDeck(name.Object));
            presenter.Setup(p => p.CombatPresenter).Returns(combatPresenter.Object);

            // When
            combatSystem.DetermineVictor(game.Object);

            // Then
            presenter.VerifyAll();
        }

        [Fact]
        public void DeterminePlayersDrew()
        {
            // Given
            Mock<IName> name = new();
            Mock<IDeck> deck = new();
            deck.Setup(d => d.IsDeckStillInPlay()).Returns(false);
            player.Setup(p => p.Deck).Returns(deck.Object);
            player.Setup(p => p.Name).Returns(name.Object);
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, player.Object });
            Mock<ICombatPresenter> combatPresenter = new();
            combatPresenter.Setup(dp => dp.PrintDraw());
            presenter.Setup(p => p.CombatPresenter).Returns(combatPresenter.Object);

            // When
            combatSystem.DetermineVictor(game.Object);

            // Then
            presenter.VerifyAll();
        }
    }
}