using System.Collections.Generic;
using Moq;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
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
            Mock<IName> name = new();
            Mock<IDeck> deck = new();
            deck.Setup(d => d.IsDeckStillInPlay(presenter.Object, name.Object)).Returns(false);
            player.Setup(p => p.Name).Returns(name.Object);
            player.Setup(p => p.Deck).Returns(deck.Object);
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, player.Object });
            spellCastingSystem.Setup(scs => scs.CastSpell(player.Object, player.Object));

            // When
            combatSystem.Start(game.Object);

            // Then
            spellCastingSystem.VerifyAll();
            player.VerifyAll();
        }
    }
}