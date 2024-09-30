namespace OpenClosedPrinciple.Strategy;
public class StandardShippingStrategy : IShippingStrategy
{
    public decimal CalculateShipping(decimal weight)
    {
        return weight * 5;
    }
}
