using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
    public class Budget
    {
        public double Value { get; }
        public List<Item> Items { get; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
