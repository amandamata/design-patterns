
namespace DesignPatterns.Strategy.Tax.Solution
{
    public class Iss : Tax
    {
        public double Calculates(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}