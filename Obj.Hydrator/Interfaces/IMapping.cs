using System.Reflection;

namespace Obj.Hydrator
{
    public interface IMapping
    {
        string PropertyName { get; }
        PropertyInfo PropertyInfo { get; }
        object Generate();
    }
}
