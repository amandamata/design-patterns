using System;

namespace DesignPatterns.Observer.Solution
{
    public static class ObserverExecute
    {
        public static void Run()
        {
           InvoiceBuilder invoiceBuilder = new InvoiceBuilder();
           invoiceBuilder
               .ToCompany("Company Name")
               .WithDocumentNumber("DocumentNumber")
               .WithItem(new InvoiceItem("item 1", 10.0))
               .WithItem(new InvoiceItem("item 2", 15.0))
               .CurrentDate()
               .WithComments("With Comments");

           invoiceBuilder.AddAction(new InvoiceDao());
           invoiceBuilder.AddAction(new SendInvoice());
           invoiceBuilder.AddAction(new SendMessage());
           
           Invoice invoice = invoiceBuilder.Builder();

           Console.WriteLine(invoice.Value);
           Console.WriteLine(invoice.Tax);
        }
    }
}
