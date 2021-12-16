namespace DesignPatterns.ChainOfResponsibility.Discount.Solution
{
    public class DiscountEmpty : IDiscount
    {
        public double Discount(Budget budget)
        {
            return 0;
        }

        public IDiscount Next { get; set; }
    }
}