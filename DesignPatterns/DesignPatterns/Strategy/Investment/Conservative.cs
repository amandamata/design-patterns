namespace DesignPatterns.Strategy.Investment
{
    public class Conservative : IInvestment
    {
        public double Invest(Account account)
        {
            return 0.008 * account.Balance;
        }
    }
}
