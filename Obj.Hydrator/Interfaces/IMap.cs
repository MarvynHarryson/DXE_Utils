using System;
using System.Reflection;

namespace Obj.Hydrator.Interfaces
{
    public interface IMap
    {
        Type Type { get; }
        bool Match(PropertyInfo info);
        IMapping Mapping(PropertyInfo info);
    }
}
