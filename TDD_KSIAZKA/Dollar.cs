namespace TDD_KSIAZKA
{
    public class Dollar
    {
        public int amount;


        public Dollar(int v)
        {
            this.amount = v;
        }

        public void times(int multiplier)
        {
            amount *=  multiplier; 
        }
    }
}