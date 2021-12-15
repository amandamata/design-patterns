
namespace DesignPatterns.Strategy.Tax.Solution
{
    public class Iccc : Tax
    {
        public double Calculates(Budget budget)
        {
            if (budget.Value < 100)
            {
                return 0.5 * budget.Value;
            }
            
            if (budget.Value >= 100 && budget.Value <= 3000)
            {
                return 0.07 * budget.Value;
            }
            
            return 0.08 * budget.Value + 30.0;
        }
    }
}
