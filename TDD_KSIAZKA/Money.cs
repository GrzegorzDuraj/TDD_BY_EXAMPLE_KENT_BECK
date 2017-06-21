using System;

namespace TDD_KSIAZKA
{
    abstract public class Money
    {
        protected int amount;
        protected string currency;
        
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object ob)
        {
            Money money = (Money)ob;
            return this.amount == money.amount && this.GetType() == ob.GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD"); 
        }

        public abstract Money Times(int multiplier);

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public object Currency()
        {
            return currency;
        }
    }
}