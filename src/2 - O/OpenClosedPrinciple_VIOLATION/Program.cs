using OpenClosedPrinciple_VIOLATION;

ShippingCalculator calculator = new ShippingCalculator();

decimal standardShippingCost = calculator.CalculateShipping("Standard", 10);
Console.WriteLine($"Standard Shipping Cost: {standardShippingCost}");

decimal expressShippingCost = calculator.CalculateShipping("Express", 10); 
Console.WriteLine($"Express Shipping Cost: {expressShippingCost}");

