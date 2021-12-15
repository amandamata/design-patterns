namespace DesignPatterns.Strategy.Tax.Problem
{
    public class Budget
    {
        public double Value { get; private set; }

        public Budget(double value)
        {
            this.Value = value;
        }
    }
}