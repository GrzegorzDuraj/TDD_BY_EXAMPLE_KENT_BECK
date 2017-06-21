using System;

namespace TDD_KSIAZKA
{
     public class Money
    {
        protected int amount;
        protected string currency;
        
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(Object ob)
        {
            Money money = (Money)ob;
            return this.amount == money.amount && Currency().Equals(money.Currency());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD"); 
        }

        public  Money Times(int multiplier)
        {
            return new Money (this.amount * multiplier, this.currency);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public object Currency()
        {
            return currency;
        }

        public new String ToString
        {
            get
            {
                return amount + " " + currency;
            }
        }
    }
}