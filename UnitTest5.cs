using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass5;
namespace asstest5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ress = Program.sum();
            int ex = 26;
            Assert.AreEqual(ex, ress);
        }
    }
}
