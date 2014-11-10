using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculadora cal = new Calculadora();
        [TestMethod]
        public void TestMethod1()
        {
            
            Assert.AreEqual(4, cal.suma(2, 2));
        }
         [TestMethod]
        public void TestMethod2()
        {
            
            Assert.AreEqual(0, cal.resta(2, 2));
        }
    }
}
