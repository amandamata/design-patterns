
namespace DesignPatterns.Strategy.Solution
{
    public class Icms : Tax
    {
        public double Calculates(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}