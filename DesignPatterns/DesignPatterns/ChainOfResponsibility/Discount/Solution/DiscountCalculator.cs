namespace DesignPatterns.ChainOfResponsibility.Discount.Solution
{
    public class DiscountCalculator
    {
        public double PerformsCalculation(Budget budget)
        {
            IDiscount discount1 = new DiscountMoreThanFiveItems();
            IDiscount discount2 = new DiscountValueGrThFiveHundred();
            IDiscount discount3 = new DiscountEmpty();

            discount1.Next = discount2;
            discount2.Next = discount3;

            return discount1.Discount(budget);
        }
    }
}
