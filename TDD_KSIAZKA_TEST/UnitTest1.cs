using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_KSIAZKA;


namespace TDD_KSIAZKA_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void BasicTest()
        {
            CheckBeforeStart checker = new CheckBeforeStart();
            int tryInt = 8;
            Assert.AreEqual(tryInt, checker.returnTheSameNumber(tryInt));
        }
    }

    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
        }

    }
}
