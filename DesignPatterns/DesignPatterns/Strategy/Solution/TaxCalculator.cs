using System;

namespace DesignPatterns.Strategy.Solution
{
    public class TaxCalculator
    {
        public static void PerformsCalculation(Budget budget, Tax tax)
        {
            Console.WriteLine(tax.Calculates(budget));
        }
    }
}
