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

        public InvoiceBuilder ToCompany(string companyName)
        {
            this.CompanyName = companyName;
            return this;
        }

        public InvoiceBuilder WithDocumentNumber(string documentNumber)
        {
            this.DocumentNumber = documentNumber;
            return this;
        }

        public InvoiceBuilder CurrentDate()
        {
            this.Date = DateTime.Now;
            return this;
        }

        public InvoiceBuilder WithComments(string comments)
        {
            this.Comments = comments;
            return this;
        }

        public InvoiceBuilder WithItem(InvoiceItem item)
        {
            Items.Add(item);
            value += item.Value;
            tax = item.Value * 0.05;
            return this;    
        }
    }
}