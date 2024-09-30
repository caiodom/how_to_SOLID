namespace InterfaceSegregationPrinciple_VIOLATION;

public interface IPrinter
{
    void Print(string document);
    void Scan(string document);
    void Fax(string document);
}
