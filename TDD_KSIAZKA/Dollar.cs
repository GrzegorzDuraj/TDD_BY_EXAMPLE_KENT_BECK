namespace TDD_KSIAZKA
{
    public class Dollar : Money
    {
        public Dollar(int v)
        {
            this.amount = v;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

    }
}