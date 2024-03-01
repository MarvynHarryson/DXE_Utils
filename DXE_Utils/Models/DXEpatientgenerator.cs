using Obj.Hydrator.Generators;
using Obj.Hydrator.Interfaces;

namespace DXE_Utils.Models
{
    public class DXEpatientgenerator : IGenerator<DDB_PAT_BASE>
    {
        static readonly IGenerator<string> FirstNameGen = new FirstNameGenerator();
        static readonly IGenerator<string> LastNameGen = new LastNameGenerator();

        public DDB_PAT_BASE Generate()
        {
            return new DDB_PAT_BASE
            {
                FIRSTNAME = FirstNameGen.Generate(),
                LASTNAME = LastNameGen.Generate(),
            };
        }
    }
}
