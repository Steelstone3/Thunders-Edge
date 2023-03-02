using System.Collections.Generic;
using Moq;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using Xunit;

namespace ThundersEdgeTests.Systems
{
    public class CombatSystemShould
    {
        private readonly Mock<IPlayer> player = new();
        private readonly Mock<IGame> game = new();
        private readonly Mock<ISpellCastingSystem> spellCastingSystem = new();
        private readonly ICombatSystem combatSystem;

        public CombatSystemShould()
        {
            combatSystem = new CombatSystem(spellCastingSystem.Object);
        }

        [Fact]
        public void StartCombat()
        {
            // Given
            game.Setup(g => g.Players).Returns(new List<IPlayer>() { player.Object, player.Object });
            spellCastingSystem.Setup(scs => scs.CastSpell(player.Object, player.Object));

            // When
            combatSystem.Start(game.Object);

            // Then
            spellCastingSystem.VerifyAll();
        }
    }
}