namespace DependencyInversionPrinciple_VIOLATION;

public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}
