namespace OpenClosedPrinciple.Strategy;

public class ExpressShippingStrategy : IShippingStrategy
{
    public decimal CalculateShipping(decimal weight)
    {
        return weight * 10;
    }
}
