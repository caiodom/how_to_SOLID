namespace DependencyInversionPrinciple;

public class EmailService : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}
