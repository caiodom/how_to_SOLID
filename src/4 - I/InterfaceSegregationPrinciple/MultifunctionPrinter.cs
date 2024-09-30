namespace InterfaceSegregationPrinciple;
public class MultifunctionPrinter : IPrinter, IScanner
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}...");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scanning document: {document}...");
    }
}
