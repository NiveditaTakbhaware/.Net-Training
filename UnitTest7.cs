using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass7;
namespace asstest7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int res = p.power();
            int ex = 9;
            Assert.AreEqual(ex, res);
        }
    }
}
