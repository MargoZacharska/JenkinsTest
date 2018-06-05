using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace TestSingleton
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Singleton.Singleton s1 = Singleton.Singleton.getInstance();
            Singleton.Singleton s2 = Singleton.Singleton.getInstance();
            Assert.AreSame(s1, s2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Singleton.Singleton s1 = Singleton.Singleton.getInstance();
            Singleton.Singleton s2 = Singleton.Singleton.getInstance();
            Assert.AreNotSame(s1, s2);
        }
    }
}
