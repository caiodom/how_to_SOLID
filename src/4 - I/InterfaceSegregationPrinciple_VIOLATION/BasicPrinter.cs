namespace InterfaceSegregationPrinciple_VIOLATION;

public class BasicPrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan(string document)
    {
        throw new NotImplementedException("Fax not supported.");
    }

    public void Fax(string document)
    {
        throw new NotImplementedException("Fax not supported.");
    }
}
