using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsilExperiments;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var instance = new JustAClass();
                instance.InitArray();
            var arr = instance.GetInitArr();
            Console.WriteLine(arr);
        }
    }
}
