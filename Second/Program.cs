using Second;

InvoiceHandler invoice = new();

Order order = new()
{
    ProductId = 3,
    CustomerId = 2,
    CustomerEmail = "myEmail@gmail.com",
    TotalPrice = 50
};

Invoice invoice1 = new()
{ 
    totalPrice = 228
};

invoice.Handler(order, invoice1);