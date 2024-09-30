namespace SingleResponsabilityPrinciple;

public class OrderItemValidator
{
    public void Validate(OrderItem item)
    {
        if (string.IsNullOrWhiteSpace(item.ProductName))
            throw new ArgumentException("Product name cannot be null or empty.");

        if (item.Price <= 0)
            throw new ArgumentException("Price must be greater than zero.");

        if (item.Quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");
    }
}
