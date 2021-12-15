using System;

namespace DesignPatterns.Strategy.Investment
{
    public class Moderate : IInvestment
    {
        private readonly Random _random;
        public Moderate()
        {
            this._random = new Random();
        }

        public double Invest(Account account) 
        {
            if(_random.Next(2) == 0) 
                return account.Balance * 0.025;
            
            return account.Balance * 0.007;
        }
    }
}
