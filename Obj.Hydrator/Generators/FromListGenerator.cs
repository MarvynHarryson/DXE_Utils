
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Obj.Hydrator.Interfaces;




    namespace Obj.Hydrator.Generators
    {
        public class FromListGenerator<T> : IGenerator<T>
        {
            readonly Random random;
            IEnumerable<T> list = new List<T>();
            public FromListGenerator(IEnumerable<T> list)
            {
                random = RandomSingleton.Instance.Random;
                this.list = list;
            }

            public T Generate()
            {
                return list.ElementAt(random.Next(0, list.Count<T>()));
            }
        }
    }
