using BubblesDivePlanner.Presenters;
using ThundersEdge.Presenters;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Services;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge
{
    internal static class Program
    {
        public static void Main()
        {
            IPresenter presenter = new Presenter();
            ICharacterPresenter characterPresenter = new CharacterPresenter(presenter);
            ISpellCastingPresenter spellCastingPresenter = new SpellCastingPresenter(presenter);
            IRandomCharacterNameSystem randomCharacterNameSystem = new RandomCharacterNameSystem();
            ICharacterNameFactory characterNameFactory = new CharacterNameFactory(randomCharacterNameSystem);
            ISpellFactory spellFactory = new SpellFactory();
            ISpellGroupFactory spellGroupFactory = new SpellGroupFactory(spellFactory);
            ICardFactory cardFactory = new CardFactory(characterNameFactory, spellGroupFactory);
            IDeckFactory deckFactory = new DeckFactory(cardFactory);
            ISpellTokenFactory pointsDeckFactory = new SpellTokenFactory();
            IPlayerSetupFactory playerSetupFactory = new PlayerSetupFactory(characterPresenter, deckFactory, pointsDeckFactory);
            IGameSetupFactory gameSetupFactory = new GameSetupFactory(playerSetupFactory);
            ISpellCastingSystem spellCastingSystem = new SpellCastingSystem(spellCastingPresenter);
            IGameService gameService = new GameService(gameSetupFactory, spellCastingSystem);

            gameService.Run();
        }
    }
}
