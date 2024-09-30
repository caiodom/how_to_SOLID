namespace SingleResponsabilityPrinciple;

public class OrderRepository
{
   public void Save(Order order)
    {
        Console.WriteLine("Order saved to the database.");
    }
}
