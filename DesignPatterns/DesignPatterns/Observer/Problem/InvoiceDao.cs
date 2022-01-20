using System;

namespace DesignPatterns.Observer.Problem
{
    public class InvoiceDao
    {
        public void SaveInvoice(Invoice invoice)
        {
            Console.WriteLine("saving invoice");
        }
    }
}