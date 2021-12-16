
namespace DesignPatterns.ChainOfResponsibility.Discount.Problem
{
    public class DiscountCalculator
    {
        public double PerformsCalculation(Budget budget)
        {
            if (budget.Items.Count > 5)
            {
                return budget.Value * 0.1;
            }
            
            if (budget.Value > 500.0)
            {
                return budget.Value * 0.07;
            }

            return 0;
        }
    }
}
// some problems with this code:
// 1. problem: if we have 10 or 15 different discounts, this class will fill with if
//
// 2. problem: this class will not be cohesive
// cohesion is the name we give when a class has a specific responsibility
// for example, the Budget class has a single responsibility, which is to represent a single budget
//
// ways to solve these problems:
// take business rules out of the DiscountCalculator class and put them in smaller classes