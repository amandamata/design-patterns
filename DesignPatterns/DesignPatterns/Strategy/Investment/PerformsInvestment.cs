using System;

namespace DesignPatterns.Strategy.Investment
{
    public class PerformsInvestment
    {
        public void Performs(Account account, IInvestment investment)
        {
            var result = investment.Invest(account);
            account.Deposit(result * 0.75);
            Console.WriteLine ( "New balance: " + account.Balance);
        }
    }
}
