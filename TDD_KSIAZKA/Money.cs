namespace TDD_KSIAZKA
{
    public class Money
    {
        public int amount;
        
        public override bool Equals(object ob)
        {
            Money money = (Money)ob;
            return this.amount == money.amount && this.GetType() == ob.GetType();
        }
    }
}