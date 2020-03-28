using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c.netass;
namespace asstest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int s = Program.name("the holiday nki kjjg ");
            //string s1 =" ";
            Assert.AreEqual(s, 4);
           
        }
    }
}
