using System;

namespace DesignPatterns.Observer.Problem
{
    public static class BuilderExecute
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

           Invoice invoice = invoiceBuilder.Builder();

           Console.WriteLine(invoice.Value);
           Console.WriteLine(invoice.Tax);
        }
    }
}
