using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class ApplySpellColourSystem : IApplySpellColourSystem
    {
        public string ApplySpellColour(CastingType castingType, IName spellName)
        {
            return castingType switch
            {
                CastingType.Conventional => $"[lightslategrey]{spellName.GenericName}[/]",
                CastingType.Life => $"[red]{spellName.GenericName}[/]",
                CastingType.Air => $"[grey84]{spellName.GenericName}[/]",
                CastingType.Water => $"[skyblue1]{spellName.GenericName}[/]",
                CastingType.Earth => $"[rosybrown]{spellName.GenericName}[/]",
                CastingType.Fire => $"[darkorange]{spellName.GenericName}[/]",
                _ => null,
            };
        }
    }
}