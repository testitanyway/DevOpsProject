using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsProject
{
    [TestClass]
    public class UnitTest1:UnitTest2
    {

        [TestMethod,TestCategory("DevOps")]
        public void TestMethod1()
        {
            System.Diagnostics.Trace.WriteLine("TestMethod1");
            string appvalue = getAppSettingJsonData("envts");
            System.Diagnostics.Trace.WriteLine(appvalue);
            Assert.IsTrue(true);
        }

        [TestMethod, TestCategory("DevOps")]
        public void TestMethod2()
        {
            System.Diagnostics.Trace.WriteLine("TestMethod2");
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            System.Diagnostics.Trace.WriteLine("TestMethod3");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            System.Diagnostics.Trace.WriteLine("TestMethod4");
            Assert.IsTrue(true);
        }
    }
}
