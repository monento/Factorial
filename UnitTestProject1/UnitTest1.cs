using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 obj = new Class1();
            int f = obj.Factorial(5);
            Assert.AreEqual(120, f);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Class1 obj = new Class1();
            int f = obj.Factorial(0);
            Assert.AreEqual(1, f);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Class1 obj = new Class1();
            int f = obj.Factorial(1);
            Assert.AreEqual(1, f);
        }
    }
}
