namespace Fifth;

public class Order
{
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public string CustomerEmail { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; }
}