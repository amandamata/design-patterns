namespace DesignPatterns.Template.Solution
{
    public abstract class ConditionalTaxTemplate : Tax
    {
        public double Calculates(Budget budget)
        {
            if (MustUseMaximumTaxation(budget))
            {
                return MaximumTaxation(budget);
            }

            return MinimumTaxation(budget);
        }

        public abstract bool MustUseMaximumTaxation(Budget budget);
        public abstract double MaximumTaxation(Budget budget);
        public abstract double MinimumTaxation(Budget budget);
    }
}
