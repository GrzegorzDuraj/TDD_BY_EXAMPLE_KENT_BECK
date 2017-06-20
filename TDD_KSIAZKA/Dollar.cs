namespace TDD_KSIAZKA
{
    public class Dollar
    {
        public int amount;


        public Dollar(int v)
        {
            this.amount = v;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals (object ob)
        {
            Dollar dollar = (Dollar)ob;
            return amount == dollar.amount;
        }
    }
}