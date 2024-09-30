namespace DependencyInversionPrinciple_VIOLATION;

public class SmsService
{
    public void SendSms(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}
