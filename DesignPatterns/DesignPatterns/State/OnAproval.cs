using System;

namespace DesignPatterns.State
{
    public class OnAproval : IBudgetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            budget.Value -= budget.Value * 0.05;
        }
        
        public void Approves(Budget budget) 
        {
            budget.CurrentState = new Approved();
        }

        public void Repproves(Budget budget) 
        {
            budget.CurrentState = new Repproved();
        }

        public void Finish(Budget budget)
        {
            throw new Exception("Budget in approval cannot go to finalized directly");
        }
    }
}
