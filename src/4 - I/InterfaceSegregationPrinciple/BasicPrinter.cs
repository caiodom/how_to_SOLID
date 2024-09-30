namespace InterfaceSegregationPrinciple;
public class BasicPrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}...");
    }
}
