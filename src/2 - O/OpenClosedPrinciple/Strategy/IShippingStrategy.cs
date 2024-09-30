namespace OpenClosedPrinciple.Strategy;

public interface IShippingStrategy
{
    decimal CalculateShipping(decimal weight);
}
