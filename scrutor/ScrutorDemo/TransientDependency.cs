using System;
using System.Collections.Generic;
using System.Text;

namespace ScrutorDemo
{
    public class TransientOne : ITransientDependency
    {
        public string GetName()
        {
            return "one";
        }
    }

    public class TransientTwo : ITransientDependency
    {
        public string GetName()
        {
            return "two";
        }
    }
}
