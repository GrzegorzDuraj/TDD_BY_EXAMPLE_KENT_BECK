namespace TDD_KSIAZKA
{
    public class Dollar
    {
        public int amount;


        public Dollar(int v)
        {
            this.amount = v;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}