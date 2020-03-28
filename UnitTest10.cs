using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass10;
namespace asstest10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res =  Program.digit();
            Assert.AreEqual(10, res);

        }
    }
}
