﻿namespace TDD_KSIAZKA
{
    public class Franc: Money
    {
        public Franc(int v)
        {
            this.amount = v;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
 
    }
}