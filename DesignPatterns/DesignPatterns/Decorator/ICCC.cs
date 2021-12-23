namespace DesignPatterns.Decorator
{
    public class Iccc : Tax
    {
        public Iccc(Tax anotherTax) : base(anotherTax) { }
        public Iccc() : base() { }

        public override double Calculates(Budget budget)
        {
            if (budget.Value < 100)
            {
                return 0.5 * budget.Value + AnotherTaxCalculation(budget);
            }

            if (budget.Value >= 100 && budget.Value <= 3000)
            {
                return 0.07 * budget.Value + AnotherTaxCalculation(budget);
            }

            return 0.08 * budget.Value + 30.0 + AnotherTaxCalculation(budget);
        }
    }
}
