namespace OpenClosedPrinciple.Strategy;

//new shipping 
public class InternationalShippingStrategy : IShippingStrategy
{

    public decimal CalculateShipping(decimal weight)
    {
        return weight * 20;
    }
}
