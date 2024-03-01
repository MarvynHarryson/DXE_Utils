using System;
using Obj.Hydrator.Interfaces;

namespace Obj.Hydrator.Generators
{
    public class GuidGenerator : IGenerator<Guid>
    {
        #region IGenerator Members

        public Guid Generate()
        {
            return Guid.NewGuid();
        }

        #endregion
    }
}
