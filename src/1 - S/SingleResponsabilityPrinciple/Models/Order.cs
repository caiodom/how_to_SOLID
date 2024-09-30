namespace SingleResponsabilityPrinciple.Models;
public class Order
{
    public List<OrderItem> Items { get; private set; }
    public string CustomerEmail { get; private set; }
    public decimal Total { get; set; }

    public Order(string customerEmail, List<OrderItem> items)
    {
        CustomerEmail = customerEmail;
        Items = items;
    }

}

