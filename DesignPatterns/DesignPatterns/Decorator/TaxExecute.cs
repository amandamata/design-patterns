using System;

namespace DesignPatterns.Decorator
{
    public static class TaxExecute
    {
        public static void Run()
        {
            Tax iss = new Iss(new Iss());

            Budget budget = new Budget(500.00);
            double value = iss.Calculates(budget);

            Console.WriteLine(value);
        }
    }
}
