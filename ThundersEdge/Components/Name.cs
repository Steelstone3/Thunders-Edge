using ThundersEdge.Components.Interfaces;

namespace ThundersEdge.Components
{
    public class Name : IName
    {
        public Name(string name)
        {
            GenericName = name;
        }

        public string GenericName { get; }
    }
}