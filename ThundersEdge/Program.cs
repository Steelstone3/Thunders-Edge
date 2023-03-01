using ThundersEdge.Assests;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Services;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;
using ThundersEdge.Systems.Spells;

namespace ThundersEdge
{
    internal static class Program
    {
        public static void Main()
        {
            IPresenter presenter = new Presenter();

            IRandomCharacterNameSystem randomCharacterNameSystem = new RandomCharacterNameSystem(new AllNames());
            IRandomSpellGroupSystem randomSpellGroupSystem = new RandomSpellGroupSystem(new AllSpellGroups());

            IGameSetupFactory gameSetupFactory = CreateGame(presenter, randomCharacterNameSystem, randomSpellGroupSystem);

            IDamagingSpellCastSystem damagingSpellCastSystem = new DamagingSpellCastSystem();
            ISpellCastingSystem spellCastingSystem = new SpellCastingSystem(presenter, damagingSpellCastSystem);
            ICombatSystem combatSystem = new CombatSystem(spellCastingSystem);

            IGameService gameService = new GameService(gameSetupFactory, combatSystem);
            gameService.Run();
        }

        private static IGameSetupFactory CreateGame(IPresenter presenter, IRandomCharacterNameSystem randomCharacterNameSystem, IRandomSpellGroupSystem randomSpellGroupSystem)
        {
            ICharacterNameFactory characterNameFactory = new CharacterNameFactory(randomCharacterNameSystem);
            ISpellGroupFactory spellGroupFactory = new SpellGroupFactory(randomSpellGroupSystem);
            ICardFactory cardFactory = new CardFactory(presenter, characterNameFactory, spellGroupFactory);
            IDeckFactory deckFactory = new DeckFactory(cardFactory);

            IAllSpellTokenFactory pointsDeckFactory = new AllSpellTokenFactory(presenter);

            IPlayerSetupFactory playerSetupFactory = new PlayerSetupFactory(presenter, deckFactory, pointsDeckFactory);

            return new GameSetupFactory(playerSetupFactory);
        }
    }
}
