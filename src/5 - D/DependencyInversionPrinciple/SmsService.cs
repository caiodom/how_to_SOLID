namespace DependencyInversionPrinciple;

public class SmsService : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}
