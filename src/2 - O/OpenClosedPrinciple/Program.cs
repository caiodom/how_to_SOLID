
using OpenClosedPrinciple.Context;
using OpenClosedPrinciple.Strategy;

// standard
IShippingStrategy standardShipping = new StandardShippingStrategy();
ShippingCalculator shippingCalculator= new ShippingCalculator(standardShipping);
var standardResult = shippingCalculator.CalculateShipping(10);
Console.WriteLine($"Standard Shipping Cost: {standardResult}");

//express
shippingCalculator.SetStrategy(new ExpressShippingStrategy());
var expressResult=shippingCalculator.CalculateShipping(10);
Console.WriteLine($"Express Shipping Cost: {expressResult}");

//international(new shipping)
shippingCalculator.SetStrategy(new InternationalShippingStrategy());
var internationalResult=shippingCalculator.CalculateShipping(10);
Console.WriteLine($"International Shipping Cost: {internationalResult}");
