using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass2;
namespace asstest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str1 = Program.name("john");
            string str2 = Program.msg();
            string ex1 = "welcome friend john";
            string ex2 = "have nice day! ";
            Assert.AreEqual(ex1, str1);
            Assert.AreEqual(ex2,str2);
        }
    }
}
