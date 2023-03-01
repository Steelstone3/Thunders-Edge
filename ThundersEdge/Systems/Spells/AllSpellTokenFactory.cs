using ThundersEdge.Assests.Interfaces;
using ThundersEdge.Components.Casting;
using ThundersEdge.Presenters.Interfaces;
using ThundersEdge.Systems.Interfaces;

namespace ThundersEdge.Systems.Spells
{
    public class AllSpellTokenFactory : IAllSpellTokenFactory
    {
        private readonly IPresenter presenter;

        public AllSpellTokenFactory(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        public IAllCastPointTokens Create()
        {
            return new AllCastPointTokens(presenter);
        }
    }
}