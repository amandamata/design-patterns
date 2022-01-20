namespace DesignPatterns.Observer.Problem
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public InvoiceItem(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
