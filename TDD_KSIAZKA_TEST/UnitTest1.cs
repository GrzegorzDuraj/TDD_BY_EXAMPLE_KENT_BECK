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
}
