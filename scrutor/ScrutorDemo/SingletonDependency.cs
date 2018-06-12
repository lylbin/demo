using System;
using System.Collections.Generic;
using System.Text;

namespace ScrutorDemo
{
    public class SingletonOne : ISingletonDependency
    {
        public int GetInt()
        {
            return 1;
        }
    }

    public class SingletonTwo : ISingletonDependency
    {
        public int GetInt()
        {
            return 2;
        }
    }
}
