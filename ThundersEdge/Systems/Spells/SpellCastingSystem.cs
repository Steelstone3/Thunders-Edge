using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class SpellCastingSystem : ISpellCastingSystem
    {
        private readonly IPresenter presenter;
        private readonly IDamagingSpellCastSystem damagingSpellCastSystem;

        public SpellCastingSystem(IPresenter presenter, IDamagingSpellCastSystem damagingSpellCastSystem)
        {
            this.presenter = presenter;
            this.damagingSpellCastSystem = damagingSpellCastSystem;
        }

        public void CastSpell(IPlayer attackingPlayer, IPlayer defendingPlayer)
        {
            presenter.SpellCastingPresenter.PrintPlayerTurn(attackingPlayer.Name);
            ICard attackingCard = presenter.SpellCastingPresenter.SelectAttackingCard(attackingPlayer.Deck);
            ICard defendingCard = presenter.SpellCastingPresenter.SelectDefendingCard(defendingPlayer.Deck);
            ISpell spell = presenter.SpellCastingPresenter.SelectSpell(attackingCard);

            spell.CastSpell(damagingSpellCastSystem, attackingPlayer.PointsTokens, defendingCard);
        }
    }
}