using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;

namespace ThundersEdge.Assests
{
    public class AllSpellColours : IAllSpellColours
    {
        public string GetSpellColour(CastingType castingType)
        {
            return castingType switch
            {
                CastingType.Conventional => "[lightslategrey]",
                CastingType.Life => "[red]",
                CastingType.Air => "[grey84]",
                CastingType.Water => "[skyblue1]",
                CastingType.Earth => "[rosybrown]",
                CastingType.Fire => "[darkorange]",
                _ => null,
            };
        }
    }
}