using System;

namespace DesignPatterns.Strategy.Solution
{
    public static class StrategyExecute
    {
        public static void Run()
        {
            Tax iss = new Iss();
            Tax icms = new Icms();

            Budget budget = new Budget(500.00);
            TaxCalculator taxCalculator = new TaxCalculator();
            
            TaxCalculator.PerformsCalculation(budget, iss);
            TaxCalculator.PerformsCalculation(budget, icms);
            
            Console.ReadKey();
        }
    }
}
