using Obj.Hydrator.Interfaces;

namespace Obj.Hydrator.Generators
{
    public class TypeGenerator<T>:IGenerator<T>
    {
        public T Generate()
        {
            return new Hydrator<T>().GetSingle();
        }
    }
}
