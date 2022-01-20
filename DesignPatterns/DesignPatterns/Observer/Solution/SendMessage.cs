using System;

namespace DesignPatterns.Observer.Solution
{
    public class SendMessage : IActionAfterGenerateInvoice
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("sending message");
        }
    }
}
