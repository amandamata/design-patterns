using System;
using DesignPatterns.Builder.Problem;

namespace DesignPatterns.Builder.Solution
{
    public static class BuilderExecute
    {
        public static void Run()
        {
           InvoiceBuilder invoiceBuilder = new InvoiceBuilder();
           invoiceBuilder.ToCompany("Company Name");
           invoiceBuilder.WithDocumentNumber("DocumentNumber");
           invoiceBuilder.WithItem(new InvoiceItem("item 1", 10.0));
           invoiceBuilder.WithItem(new InvoiceItem("item 2", 15.0));
           invoiceBuilder.CurrentDate();
           invoiceBuilder.WithComments("With Comments");

           Invoice invoice = invoiceBuilder.Builder();
           
           Console.WriteLine(invoice.Value);
           Console.WriteLine(invoice.Tax);
        }
    }
}
