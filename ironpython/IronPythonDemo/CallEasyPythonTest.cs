using System;
using Xunit;
using IronPython.Hosting;

namespace IronPythonDemo
{
    public class CallEasyPythonTest
    {
        [Fact]
        public void Call_GetStr_Test()
        {
            var runtime = Python.CreateRuntime();
            dynamic py = runtime.UseFile("test.py");

            string a = py.getStr();

            Console.WriteLine(a);
        }

        [Fact]
        public void Call_GetStrByInput_Test()
        {
            var runtime = Python.CreateRuntime();

        }
    }
}
