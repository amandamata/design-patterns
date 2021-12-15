namespace DesignPatterns.Strategy.Investment
{
    public class Account
    {
        public double Balance { get; private set; }

        public void Deposit(double value)
        {
            this.Balance = value;
        }
    }
}
