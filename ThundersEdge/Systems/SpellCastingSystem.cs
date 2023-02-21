using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class SpellCastingSystem : ISpellCastingSystem
    {
        private readonly ISpellCastingPresenter spellCastingPresenter;

        public SpellCastingSystem(ISpellCastingPresenter spellCastingPresenter)
        {
            this.spellCastingPresenter = spellCastingPresenter;
        }

        public void CastSpell(IPlayer attackingPlayer, IPlayer defendingPlayer)
        {
            ICard attackingCard = spellCastingPresenter.SelectAttackingCard(attackingPlayer.Deck);
            ICard defendingCard = spellCastingPresenter.SelectDefendingCard(defendingPlayer.Deck);
            ISpell spell = spellCastingPresenter.SelectSpell(attackingCard);

            spell.CastSpell(attackingPlayer.PointsTokens, defendingCard);
        }
    }
}