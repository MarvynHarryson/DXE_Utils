using System.Collections.Generic;
using Obj.Hydrator.Interfaces;

namespace Obj.Hydrator.Generators
{
    public class GenderGenerator : IGenerator<string>
    {



        public string Generate()
        {
            return ((IGenerator<string>)new FromListGetSingleGenerator<string>(new List<string> { "Male", "Female" })).Generate();
        }
    }
}
