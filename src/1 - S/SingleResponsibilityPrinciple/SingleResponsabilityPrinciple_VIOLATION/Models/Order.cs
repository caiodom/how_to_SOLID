namespace SingleResponsabilityPrinciple_VIOLATION.Models;

public class Order
{
    public List<OrderItem> Items { get; set; }
    public string CustomerEmail { get; set; }
    public decimal Total { get; set; }
}

