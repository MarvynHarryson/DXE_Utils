using System.Collections.Generic;
using Obj.Hydrator.Interfaces;


namespace Obj.Hydrator.Generators
{
    public class CreditCardTypeGenerator:IGenerator<string>
    {
 
        public string Generate()
        {
            return
                new FromListGetSingleGenerator<string>(new List<string>
                                                  {
                                                      "MasterCard",
                                                      "Visa",
                                                      "Discover",
                                                      "American Express"
                                                  })
                    .Generate();
        }
    }
}
