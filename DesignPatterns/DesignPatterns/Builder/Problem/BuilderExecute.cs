using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder.Problem
{
    public static class BuilderExecute
    {
        public static void Run()
        {
            List<InvoiceItem> items = new List<InvoiceItem>();
            double value = 0;
            
            foreach (var invoiceItem in items)
            {
                value += invoiceItem.Value;
            }

            double tax = value * 0.05;
            
            Invoice invoice = new Invoice(
                "CompanyName",
                "DocumentNumber",
                DateTime.Now,
                value,
                tax,
                items,
                "Comments" );
        }
    }
}
// problem: this code is big and complicated, many lines of code and complicated. We need to find the easiest way to do this.