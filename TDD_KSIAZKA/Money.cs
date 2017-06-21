using System;

namespace TDD_KSIAZKA
{
    abstract public class Money
    {
        public int amount;
        
        public override bool Equals(object ob)
        {
            Money money = (Money)ob;
            return this.amount == money.amount && this.GetType() == ob.GetType();
        }

        public static Money Dollar(int v)
        {
            return new Dollar(v);
        }

        public abstract Money Times(int multiplier);

        public static Money Franc(int v)
        {
            return new Franc(v);
        }
    }
}