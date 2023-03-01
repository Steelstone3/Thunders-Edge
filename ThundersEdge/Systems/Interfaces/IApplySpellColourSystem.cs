using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface IApplySpellColourSystem
    {
        string ApplySpellColour(CastingType castingType, IName spellName);
    }
}