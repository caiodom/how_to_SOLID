namespace DependencyInversionPrinciple;

public class NotificationService
{
    private readonly INotificationSender _notificationSender;
    public NotificationService(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }

    public void SendNotification(string message)
    {
        _notificationSender.Send(message);
    }
}
