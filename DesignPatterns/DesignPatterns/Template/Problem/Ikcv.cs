using System.Linq;

namespace DesignPatterns.Template.Problem
{
    public class Ikcv : Tax
    {
        public double Calculates(Budget budget)
        {
            if (budget.Value > 500 && hasItemBiggestThan100In(budget))
            {
                return budget.Value * 0.1;
            }
            return budget.Value * 0.06;
        }
        
        private bool hasItemBiggestThan100In(Budget budget)
        {
            return budget.Items.Any(item => item.Value > 100);
        }
    }
}
// we have two taxes whose calculation algorithm is similar
// to solve it, we created an abstract class that represents the calculation algorithm and abstract methods that are like the holes that the abstract class will have to implement.