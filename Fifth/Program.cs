using Fifth;

OrderProcessor order = new();

Order order1 = new()
{
    ProductId = 4,
    CustomerId = 2,
    CustomerEmail = "kurbonovs397@gmail.com",
    TotalPrice = 20
};

order.ProcessOrder(order1);