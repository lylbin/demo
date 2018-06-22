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
            var engine = Python.CreateEngine();
            var searchPaths = engine.GetSearchPaths();
            searchPaths.Add(@"C:\Users\97669\AppData\Local\Programs\Python\Python36-32\Lib");
            engine.SetSearchPaths(searchPaths);

            dynamic script = engine.ExecuteFile("test.py");
            string a = script.getStr();

            Console.WriteLine(a);
        }

        [Fact]
        public void Call_GetStrByInput_Test()
        {
            var runtime = Python.CreateRuntime();

        }
    }
}
