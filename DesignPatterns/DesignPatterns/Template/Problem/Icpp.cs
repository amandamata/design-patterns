namespace DesignPatterns.Template.Problem
{
    public class Icpp : Tax
    {
        public double Calculates(Budget budget)
        {
            if (budget.Value > 500)
            {
                return budget.Value * 0.07;
            }

            return budget.Value * 0.05;
        }
    }
}
