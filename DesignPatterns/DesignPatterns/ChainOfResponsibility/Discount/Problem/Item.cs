
namespace DesignPatterns.ChainOfResponsibility.Discount.Problem
{
    public class Item
    {
        private string Name { get; }
        private double Value { get; }
    
        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
