namespace SingleResponsabilityPrinciple;
public class OrderValidator
{
    public void Validate(Order order)
    {
        if (string.IsNullOrEmpty(order.CustomerEmail) || !order.CustomerEmail.Contains("@"))
            throw new ArgumentException("Invalid email address.");

        if (order.Items == null || !order.Items.Any())
            throw new ArgumentException("Order must contain at least one item.");
    }
}

