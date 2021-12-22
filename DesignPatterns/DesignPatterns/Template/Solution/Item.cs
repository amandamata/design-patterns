namespace DesignPatterns.Template.Solution
{
    public class Item
    {
        public string Name { get; }
        public double Value { get; }
    
        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
