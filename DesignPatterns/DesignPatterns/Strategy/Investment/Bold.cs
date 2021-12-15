using System;

namespace DesignPatterns.Strategy.Investment
{
    public class Bold : IInvestment
    {
        private readonly Random _random;

        public Bold()
        {
            this._random = new Random();
        }
        
        public double Invest(Account account) 
        {
            var chance = _random.Next(10);
            if (chance >= 0 && chance <= 1) return account.Balance * 0.5;
            if (chance >= 2 && chance <= 4) return account.Balance * 0.3;
            return account.Balance * 0.006;
        }
    }
}
