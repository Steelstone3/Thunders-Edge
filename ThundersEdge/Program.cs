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
            ICharacterNameFactory characterNameFactory = new CharacterNameFactory(randomCharacterNameSystem);
            IRandomSpellGroupSystem randomSpellGroupSystem = new RandomSpellGroupSystem(new AllSpellGroups());
            ISpellGroupFactory spellGroupFactory = new SpellGroupFactory(randomSpellGroupSystem);
            ICardFactory cardFactory = new CardFactory(presenter, characterNameFactory, spellGroupFactory);
            IDeckFactory deckFactory = new DeckFactory(cardFactory);
            IAllSpellTokenFactory pointsDeckFactory = new AllSpellTokenFactory();
            IPlayerSetupFactory playerSetupFactory = new PlayerSetupFactory(presenter, deckFactory, pointsDeckFactory);
            IGameSetupFactory gameSetupFactory = new GameSetupFactory(playerSetupFactory);
            IDamagingSpellCastSystem damagingSpellCastSystem = new DamagingSpellCastSystem();
            ISpellCastingSystem spellCastingSystem = new SpellCastingSystem(presenter, damagingSpellCastSystem);
            IGameService gameService = new GameService(gameSetupFactory, spellCastingSystem);

            gameService.Run();
        }
    }
}
