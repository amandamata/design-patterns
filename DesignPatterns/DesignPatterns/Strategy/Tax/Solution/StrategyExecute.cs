using System;

namespace DesignPatterns.Strategy.Tax.Solution
{
    public static class StrategyExecute
    {
        public static void Run()
        {
            Tax iss = new Iss();
            Tax icms = new Icms();
            Tax iccc = new Iccc();
            
            Budget budget = new Budget(500.00);
            TaxCalculator taxCalculator = new TaxCalculator();
            
            TaxCalculator.PerformsCalculation(budget, iss);
            TaxCalculator.PerformsCalculation(budget, icms);
            TaxCalculator.PerformsCalculation(budget, iccc);
            
            Console.ReadKey();
        }
    }
}
