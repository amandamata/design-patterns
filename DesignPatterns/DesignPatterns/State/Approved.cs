using System;

namespace DesignPatterns.State
{
    public class Approved : IBudgetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            budget.Value -= budget.Value * 0.02;
        }
        
        public void Approves(Budget budget) 
        {
            throw new Exception("Budget is already in approval status");
        }

        public void Repproves(Budget budget) 
        {
            throw new Exception("Budget is in approval status and cannot be disapproved");
        }

        public void Finish(Budget budget)
        {
            budget.CurrentState = new Finished();
        }
    }
}
