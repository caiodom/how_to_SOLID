using OpenClosedPrinciple.Strategy;

namespace OpenClosedPrinciple.Context;

public class ShippingCalculator(IShippingStrategy shippingStrategy)
{

    public void SetStrategy(IShippingStrategy strategy)
    {
        shippingStrategy = strategy;
    }
    public decimal CalculateShipping(decimal weight)
    {
        return shippingStrategy.CalculateShipping(weight);
    }


}
