using System;

namespace DesignPatterns.State
{
    public static class StateExecute
    {
        public static void Run()
        {
            Budget budget = new Budget(500.0);

            budget.ApplyExtraDiscount();
            Console.WriteLine(budget.Value);
            budget.Approves();

            budget.ApplyExtraDiscount();
            Console.WriteLine(budget.Value);

            budget.Finishes();
        }
    }
}
