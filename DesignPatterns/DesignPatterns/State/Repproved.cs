using System;

namespace DesignPatterns.State
{
    public class Repproved : IBudgetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            throw new Exception("Disapproved quotes do not receive extra discount!");
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
