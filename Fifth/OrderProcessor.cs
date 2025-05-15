namespace Fifth;

public class OrderProcessor
{
    ProcessOrder order1 = new();
    CalculateDiscount discount = new();
    SendConfirmationEmail confirm = new();
    SaveOrderToDatabase saveOrder = new();

    public void ProcessOrder(Order order)
    {
        order1.ProcessOrderMethod(order);

        discount.CalculateDiscountMethod(order);

        confirm.SendConfirmationEmailMethod(order);

        saveOrder.SaveOrderToDatabaseMethod(order);
    }
}