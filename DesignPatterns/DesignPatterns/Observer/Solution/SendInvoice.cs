using System;

namespace DesignPatterns.Observer.Solution
{
    public class SendInvoice : IActionAfterGenerateInvoice
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("sending invoice by email");
        }
    }
}
