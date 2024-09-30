namespace DependencyInversionPrinciple;

public class NotificationService(INotificationSender notificationSender)
{
    public void SendNotification(string message)
    {
        notificationSender.Send(message);
    }
}
