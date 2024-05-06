using Liba;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//такого дерьма должно быть ~10
        public void TestMethod1()
        {
            int expResult = 0;
            int actResult = Balvan.Add(-1, 1);
            Assert.AreEqual(expResult, actResult, "Тест1");
        }
    }
}
