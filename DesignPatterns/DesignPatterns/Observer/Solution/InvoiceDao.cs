using System;

namespace DesignPatterns.Observer.Solution
{
    public class InvoiceDao : IActionAfterGenerateInvoice
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("saving invoice");
        }
    }
}