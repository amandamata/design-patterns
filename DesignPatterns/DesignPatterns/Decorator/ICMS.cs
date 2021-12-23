namespace DesignPatterns.Decorator
{
    public class Icms : Tax
    {
        public Icms(Tax anotherTax) : base(anotherTax) { }
        public Icms() : base() { }

        public override double Calculates(Budget budget)
        {
            return budget.Value * 0.01 + AnotherTaxCalculation(budget);
        }
    }
}
