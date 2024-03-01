using System;
using Obj.Hydrator.Interfaces;
using System.Reflection;
using Obj.Hydrator.Generators;

namespace Obj.Hydrator
{
    public class EnumMap:IMap
    {

        #region IMap Members

        Type IMap.Type
        {
            get { return typeof(object); }
        }

        bool IMap.Match(PropertyInfo info)
        {
            return info.PropertyType.IsEnum;
        }

        IMapping IMap.Mapping(PropertyInfo info)
        {
            return new Mapping<object>(info, new EnumGenerator(Enum.GetValues(info.PropertyType)));
        }

        #endregion
    }
}
