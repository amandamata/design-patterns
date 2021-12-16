namespace DesignPatterns.ChainOfResponsibility.Discount.Solution
{
    public interface IDiscount
    {
        double Discount(Budget budget);
        IDiscount Next { get; set; }
    }
}
