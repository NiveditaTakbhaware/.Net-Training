using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass8;
namespace asstest8
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = Program.fab(5);
            int ex = 3;
            Assert.AreEqual(ex, res);
        }
    }
}
