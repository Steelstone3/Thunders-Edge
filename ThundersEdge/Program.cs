using ThundersEdge.Services;
using ThundersEdge.Systems;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge
{
    internal static class Program
    {
        public static void Main()
        {
            IRandomCharacterNameSystem randomCharacterNameSystem = new RandomCharacterNameSystem();
            ICharacterNameFactory characterNameFactory = new CharacterNameFactory(randomCharacterNameSystem);
            ISpellFactory spellFactory = new SpellFactory();
            ISpellGroupFactory spellGroupFactory = new SpellGroupFactory(spellFactory);
            ICardFactory cardFactory = new CardFactory(characterNameFactory, spellGroupFactory);
            IDeckFactory deckFactory = new DeckFactory(cardFactory);
            ISpellTokenFactory pointsDeckFactory = new SpellTokenFactory();
            IPlayerSetupFactory playerSetupFactory = new PlayerSetupFactory(deckFactory, pointsDeckFactory);
            IGameSetupFactory gameSetupFactory = new GameSetupFactory(playerSetupFactory);
            IGameService gameService = new GameService(gameSetupFactory);

            gameService.Run();
        }
    }
}
