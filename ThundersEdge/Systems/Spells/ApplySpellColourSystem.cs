using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Character;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class ApplySpellColourSystem : IApplySpellColourSystem
    {
        public IName ApplySpellColour(CastingType castingType, IName spellName)
        {
            return castingType switch
            {
                CastingType.Conventional => new Name($"[lightslategrey]{spellName.GenericName}[/]"),
                CastingType.Life => new Name($"[red]{spellName.GenericName}[/]"),
                CastingType.Air => new Name($"[grey84]{spellName.GenericName}[/]"),
                CastingType.Water => new Name($"[skyblue1]{spellName.GenericName}[/]"),
                CastingType.Earth => new Name($"[rosybrown]{spellName.GenericName}[/]"),
                CastingType.Fire => new Name($"[darkorange]{spellName.GenericName}[/]"),
                _ => null,
            };
        }
    }
}