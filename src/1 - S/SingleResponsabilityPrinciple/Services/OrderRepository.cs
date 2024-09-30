using SingleResponsabilityPrinciple.Models;

namespace SingleResponsabilityPrinciple.Services;
public class OrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine("Order saved to the database.");
    }
}
