//imports necessary libraries
using System;
using System.Collections.Generic;

class InvoiceGroup : Invoice
{
    public DateTime IssueDate { get; set; }
    public List<Invoice> Invoices { get; set; }
}
