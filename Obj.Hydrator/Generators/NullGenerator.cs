using Obj.Hydrator.Interfaces;

namespace Obj.Hydrator.Generators
{
    public class NullGenerator:IGenerator<object>
    {
        public object Generate()
        {
            return null;
        }
    }
}
