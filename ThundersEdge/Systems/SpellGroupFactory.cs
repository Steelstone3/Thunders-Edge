using System.Collections.Generic;
using ThundersEdge.Components;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems
{
    public class SpellGroupFactory : ISpellGroupFactory
    {
        private const int SPELL_COUNT = 3;
        private readonly ISpellFactory spellFactory;

        public SpellGroupFactory(ISpellFactory spellFactory)
        {
            this.spellFactory = spellFactory;
        }

        public ISpellGroup Create()
        {
            return new SpellGroup(AddSpells());
        }

        private IEnumerable<ISpell> AddSpells()
        {
            List<ISpell> spells = new();

            for (int i = 0; i < SPELL_COUNT; i++)
            {
                spells.Add(spellFactory.Create());
            }

            return spells;
        }
    }
}