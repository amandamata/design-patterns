namespace DesignPatterns.Decorator
{
    public abstract class Tax
    {
        private Tax AnotherTax { get; }

        protected Tax(Tax anotherTax)
        {
            AnotherTax = anotherTax;
        }

        protected Tax()
        {
            AnotherTax = null;
        }

        public abstract double Calculates(Budget budget);

        protected double AnotherTaxCalculation(Budget budget)
        {
            if (AnotherTax == null) return 0;
            return AnotherTax.Calculates(budget);
        }
    }
}
