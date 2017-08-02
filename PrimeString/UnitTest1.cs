using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var kata = new Kata();
            var abc = kata.PrimeString("myjinxin.myjinxin");
            Assert.AreEqual(true,abc);
        }

    }

}
