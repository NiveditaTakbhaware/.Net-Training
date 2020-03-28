using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass3;
namespace asstest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int res = p.sum(15,16);
            int ex1 = 31;
            Assert.AreEqual(ex1, res);
        }
    }
}
