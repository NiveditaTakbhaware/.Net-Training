using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netassignmnt;
namespace asstest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string st = Program.msg1();
            string st2 = Program.msg2();
            string ex1= "welocome friends";
            string ex2= "have nice day";
            Assert.AreEqual(ex1, st);
            Assert.AreEqual(ex2, st2);
        }
    }
}
