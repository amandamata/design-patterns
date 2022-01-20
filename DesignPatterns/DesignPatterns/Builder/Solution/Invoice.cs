using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder.Solution
{
    public class Invoice
    {
        public string CompanyName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public double Value { get; set; }
        public double Tax { get; set; }
        public IList<InvoiceItem>Items { get; set; }
        public string Comments { get; set; }

        public Invoice(
            string companyName,
            string documentNumber,
            DateTime issueDate,
            double Value,
            double tax,
            IList<InvoiceItem> items,
            string comments)
        {
            this.CompanyName = companyName;
            this.DocumentNumber = documentNumber;
            this.IssueDate = issueDate;
            this.Value = Value;
            this.Tax = tax;
            this.Items = items;
            this.Comments = comments;
        }
    }
}
