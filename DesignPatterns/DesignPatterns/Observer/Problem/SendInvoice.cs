using System;

namespace DesignPatterns.Observer.Problem
{
    public class SendInvoice
    {
        public void SendInvoiceMail(Invoice invoice)
        {
            Console.WriteLine("sending invoice by email");
        }
    }
}
