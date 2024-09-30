namespace SingleResponsabilityPrinciple;

public class OrderCalculator
{
    public void CalculateTotal(Order order)
    {
        decimal total = 0;

        foreach (var item in order.Items)
            total += item.Price * item.Quantity;

        order.Total = total;
    }
}
