using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Problem
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
            Invoice invoice = new Invoice(CompanyName, DocumentNumber, Date, value, tax, Items, Comments);
            new SendInvoice().SendInvoiceMail(invoice);
            new InvoiceDao().SaveInvoice(invoice);
            new SendMessage().SendSMS(invoice);
            // when you find classes that do similar things, It has the same the same abstraction, represent this abstraction
            return invoice;
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