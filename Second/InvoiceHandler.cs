namespace Second;

public class InvoiceHandler
{
    GenerateInvoice generate = new();
    PrintInvoice print = new();
    EmailInvoice email = new();

    public void Handler(Order order, Invoice invoice)
    {
        generate.GenerateInvoiceMethod(order);

        print.PrintInvoiceMehtod(invoice);

        email.EmailInvoiceMethod(invoice);
    }
}