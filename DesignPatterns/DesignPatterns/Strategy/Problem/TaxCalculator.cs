using System;

namespace DesignPatterns.Strategy.Problem
{
    public class TaxCalculator
    {
        public void PerformsCalculation(Budget budget)
        {
            if ("ICMS".Equals(budget))
            {
                double icms = budget.Value * 0.1;
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(budget))
            {
                double iss = budget.Value * 0.06;
                Console.WriteLine(iss);
            }
        }
    }
}

// some problems with this code:
// 1. problem: if we have 10 or 15 different taxes, this class will fill with if
//
// 2. problem: this class will not be cohesive
// cohesion is the name we give when a class has a specific responsibility
// for example, the Budget class has a single responsibility, which is to represent a single budget
//
// ways to solve these problems:
// take business rules out of the TaxCalculator class and put them in smaller classes