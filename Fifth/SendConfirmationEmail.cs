namespace Fifth;

public class SendConfirmationEmail
{
    public void SendConfirmationEmailMethod(Order order)
    {
        System.Console.WriteLine($"A message has been sent to your email {order.CustomerEmail}");
    }
}