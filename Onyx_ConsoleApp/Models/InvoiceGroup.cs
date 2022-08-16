//invoicegroup class, inherits from invoice

class InvoiceGroup : Invoice
{
    public DateTime IssueDate { get; set; }
    public List<Invoice> Invoices { get; set; }
}
