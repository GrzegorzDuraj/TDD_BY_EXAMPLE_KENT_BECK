using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_KSIAZKA;


namespace TDD_KSIAZKA_TEST
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void testMultiplication()
        {
            Money five = Money.Dollar(5);
            Money five2 = five.Times(2);
            Money dollar10 = Money.Dollar(10);
            Assert.AreEqual(five2, dollar10);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void testEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsTrue(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Franc(5)));
        }

        [TestMethod]
        public void testDifferentClassEquality()
        {
            Assert.IsTrue(new Money(10, "CHF").Equals(new Franc(10, "CHF")));

        }

        [TestMethod]
        public void testFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [TestMethod]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency()); 
        }
    }
}
