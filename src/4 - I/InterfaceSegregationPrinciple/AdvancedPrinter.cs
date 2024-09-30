namespace InterfaceSegregationPrinciple;

public class AdvancedPrinter : IPrinter, IScanner, IFax
{
    public void Fax(string document)
    {
        Console.WriteLine($"Sending fax: {document}...");
    }

    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}...");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scanning document: {document}...");
    }
}
