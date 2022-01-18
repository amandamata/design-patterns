using System;
using System.Collections.Generic;
using DesignPatterns.Builder.Problem;
using DesignPatterns.Decorator;

namespace DesignPatterns.Builder.Solution
{
    public class InvoiceBuilder
    {
        public string CompanyName { get; private set; }
        public string DocumentNumber { get; private set; }
        public DateTime Date { get; private set; }
        public string Comments { get; private set; }

        private double value;
        private double tax;
        private IList<InvoiceItem> Items = new List<InvoiceItem>();

        public Invoice Builder()
        {
            return new Invoice(CompanyName, DocumentNumber, Date, value, tax, Items, Comments);
        }

        public void ToCompany(string companyName)
        {
            this.CompanyName = companyName;
        }

        public void WithDocumentNumber(string documentNumber)
        {
            this.DocumentNumber = documentNumber;
        }

        public void CurrentDate()
        {
            this.Date = DateTime.Now;
        }

        public void WithComments(string comments)
        {
            this.Comments = comments;
        }

        public void WithItem(InvoiceItem item)
        {
            Items.Add(item);
            value += item.Value;
            tax = item.Value * 0.05;
        }
    }
}