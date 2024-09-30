namespace OpenClosedPrinciple_VIOLATION;

public class ShippingCalculator
{
    public decimal CalculateShipping(string shippingType, decimal weight)
    {
        if (shippingType == "Standard")
            return weight * 5; 
        else if (shippingType == "Express")
            return weight * 10;
        else
            throw new ArgumentException("Invalid shipping type");
    }

}
