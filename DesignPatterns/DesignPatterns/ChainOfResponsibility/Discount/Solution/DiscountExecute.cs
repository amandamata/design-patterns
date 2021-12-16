using System;

namespace DesignPatterns.ChainOfResponsibility.Discount.Solution
{
    public static class DiscountExecute
    {
        public static void Run()
        {
            DiscountCalculator discountCalculator = new DiscountCalculator();
            Budget budget = new Budget(400);
            budget.AddItem(new Item("Pencil", 250));
            budget.AddItem(new Item("Notebook", 250));

            double discount = discountCalculator.PerformsCalculation(budget);
            
            Console.WriteLine(discount);
            Console.ReadKey();
        }
    }
}
