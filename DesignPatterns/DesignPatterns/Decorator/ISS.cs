namespace DesignPatterns.Decorator
{
    public class Iss : Tax
    {
        public Iss(Tax anotherTax) : base(anotherTax) { }
        public Iss() : base() { }

        public override double Calculates(Budget budget)
        {
            return budget.Value * 0.06 + AnotherTaxCalculation(budget);
        }
    }
}
