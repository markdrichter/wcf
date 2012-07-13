using System.Collections.Generic;

namespace Component_2
{
    public class Class1
    {
        public int Count()
        {
            return 10;
        }

        public IList<string> GetList()
        {
            return new List<string> {"a", "b", "c"};
        }
    }
}
