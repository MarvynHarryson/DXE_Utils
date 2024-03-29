﻿using System;
using Obj.Hydrator.Interfaces;
using System.Reflection;

namespace Obj.Hydrator.Generators
{
    public class Generator:IGenerator
    {
        private readonly PropertyInfo _info;

        public Generator(PropertyInfo info)
        {
            _info = info;
        }
        #region Implementation of IGenerator

        public object Generate()
        {
            if (_info.PropertyType.IsArray)
            {
                return Array.CreateInstance(_info.PropertyType.GetElementType(), 0);
            }

            return Activator.CreateInstance(_info.PropertyType);
        }

        #endregion
    }
}
