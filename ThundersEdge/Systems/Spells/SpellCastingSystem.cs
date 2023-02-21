using ThundersEdge.Components.Interfaces;
using ThundersEdge.Entities.Interfaces;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class SpellCastingSystem : ISpellCastingSystem
    {
        private readonly ISpellCastingPresenter spellCastingPresenter;
        private readonly IDamagingSpellCastSystem damagingSpellCastSystem;

        public SpellCastingSystem(ISpellCastingPresenter spellCastingPresenter)
        {
            this.spellCastingPresenter = spellCastingPresenter;
        }

        public SpellCastingSystem(ISpellCastingPresenter spellCastingPresenter, IDamagingSpellCastSystem damagingSpellCastSystem)
        {
            this.spellCastingPresenter = spellCastingPresenter;
            this.damagingSpellCastSystem = damagingSpellCastSystem;
        }

        public void CastSpell(IPlayer attackingPlayer, IPlayer defendingPlayer)
        {
            ICard attackingCard = spellCastingPresenter.SelectAttackingCard(attackingPlayer.Deck);
            ICard defendingCard = spellCastingPresenter.SelectDefendingCard(defendingPlayer.Deck);
            ISpell spell = spellCastingPresenter.SelectSpell(attackingCard);

            spell.CastSpell( damagingSpellCastSystem, attackingPlayer.PointsTokens, defendingCard);
        }
    }
}