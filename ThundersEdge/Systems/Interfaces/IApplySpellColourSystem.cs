using ThundersEdge.Components.Casting;
using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Systems.Interfaces
{
    public interface IApplySpellColourSystem
    {
        IName ApplySpellColour(CastingType castingType, IName spellName);
    }
}