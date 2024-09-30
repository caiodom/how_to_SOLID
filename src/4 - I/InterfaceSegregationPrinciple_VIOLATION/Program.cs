// Basic printer
using InterfaceSegregationPrinciple_VIOLATION;

IPrinter basicPrinter = new BasicPrinter();
basicPrinter.Print("Basic document");

// Attempting to use the Fax method, which doesn't make sense for BasicPrinter
try
{
    basicPrinter.Fax("Basic document"); // This will throw an exception
}
catch (NotImplementedException ex)
{
    Console.WriteLine(ex.Message); // Output: Fax not supported.
}