using System.Collections.Generic;

namespace DesignPatterns.State
{
    public class Budget
    {
        public double Value { get; set; }
        public IBudgetState CurrentState { get; set; }
        public List<Item> Items { get; }

        public Budget(double value)
        {
            Value = value;
            Items = new List<Item>();
            CurrentState = new OnAproval();
        }

        public void ApplyExtraDiscount()
        {
            CurrentState.ApplyExtraDiscount(this);
        }

        public void Approves()
        {
            CurrentState.Approves(this);
        }
        
        
        public void Repproves()
        {
            CurrentState.Repproves(this);
        }
        
        public void Finishes()
        {
            CurrentState.Finish(this);
        }
        
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
