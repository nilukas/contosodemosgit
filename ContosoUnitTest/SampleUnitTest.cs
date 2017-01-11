using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContosoUnitTest
{
    [TestClass]
    public class SampleUnitTest
    {
        [TestMethod]
        public void TestPass()
        {
            Assert.AreEqual(10, 10);
        }
        [TestMethod]
        public void TestFail()
        {
            Assert.AreEqual(5, 5);
        }
    }
}
