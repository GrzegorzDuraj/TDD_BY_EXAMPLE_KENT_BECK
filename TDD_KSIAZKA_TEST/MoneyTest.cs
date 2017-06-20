﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_KSIAZKA;


namespace TDD_KSIAZKA_TEST
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.amount);
        }

        [TestMethod]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }


    }
}
