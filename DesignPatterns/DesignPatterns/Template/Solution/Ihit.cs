using System.Collections.Generic;

namespace DesignPatterns.Template.Solution
{
    public class Ihit : ConditionalTaxTemplate
    {
        public override bool MustUseMaximumTaxation(Budget budget)
        {
            List<string> inBudget = new List<string>();
            foreach (var x in budget.Items)
            {
                if (inBudget.Contains(x.Name))
                {
                    return true;
                }
                inBudget.Add(x.Name);
            }

            return false;
        }

        public override double MaximumTaxation(Budget budget)
        {
            return budget.Value * 0.13 + 100;
        }

        public override double MinimumTaxation(Budget budget)
        {
            return budget.Value * (0.01 * budget.Items.Count);
        }
    }
}
