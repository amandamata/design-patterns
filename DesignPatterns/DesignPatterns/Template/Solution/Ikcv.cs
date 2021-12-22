namespace DesignPatterns.Template.Solution
{
    public class Ikcv : ConditionalTaxTemplate
    {
        private bool hasItemBiggestThan100In(Budget budget)
        {
            foreach (var item in budget.Items)
            {
                if (item.Value > 100) return true;
            }
            return false;
        }
        
        public override bool MustUseMaximumTaxation(Budget budget)
        {
            return budget.Value > 500 && hasItemBiggestThan100In(budget);
        }

        public override double MaximumTaxation(Budget budget)
        {
            return budget.Value * 0.10;
        }

        public override double MinimumTaxation(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}
